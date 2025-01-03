using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.TournamentSoftware;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TsDataServer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
        }

        private AppSettings appSettings = new AppSettings();
        private readonly TsDatabaseAdapter tsAdapter = new TsDatabaseAdapter();
        private RabbitAdapter rabbitAdapter;
        private DateTime lastUpdate;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(AppSettings.Filename))
            {
                this.appSettings = AppSettings.LoadFromFile(AppSettings.Filename);
                this.TxtDatabaseFilepath.Text = this.appSettings.DatabaseFilePath;
                this.ChbRabbit.Checked = this.appSettings.RabbitEnabled;
                this.TxtRabbitServer.Text = this.appSettings.RabbitServer;
                this.TxtRabbitUser.Text = this.appSettings.RabbitUser;
                this.TxtRabbitPassword.Text = this.appSettings.RabbitPassword;
                this.TxtRabbitVhost.Text = this.appSettings.RabbitVhost;
                this.ChbJson.Checked = this.appSettings.JsonEnabled;
                this.TxtJsonFilePath.Text = this.appSettings.JsonFilePath;
                this.NudInterval.Value = this.appSettings.Interval;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Stop();
                        
            this.appSettings.DatabaseFilePath = this.TxtDatabaseFilepath.Text;
            this.appSettings.RabbitEnabled = this.ChbRabbit.Checked;
            this.appSettings.RabbitServer = this.TxtRabbitServer.Text;
            this.appSettings.RabbitVhost = this.TxtRabbitVhost.Text;
            this.appSettings.RabbitUser = this.TxtRabbitUser.Text;
            this.appSettings.RabbitPassword = this.TxtRabbitPassword.Text;
            this.appSettings.JsonEnabled = this.ChbJson.Checked;
            this.appSettings.JsonFilePath = this.TxtJsonFilePath.Text;
            this.appSettings.Interval = (int)this.NudInterval.Value;
            AppSettings.SaveToFile(AppSettings.Filename, this.appSettings);

            this.tsAdapter.Close();
            if (this.rabbitAdapter != null)
            {
                this.rabbitAdapter.Close();
            }
        }

        private void BtnStartAutoUpdate_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void BtnStopAutoupdate_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void TmrUpdater_Tick(object sender, EventArgs e)
        {
            try
            {
                this.LoadMatches();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\r\n\r\n" + ex, "TS Data Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TmrUpdater.Stop();
            }
        }

        private void TmrCountdown_Tick(object sender, EventArgs e)
        {            
            var timeLeft = this.lastUpdate.AddSeconds((int)this.NudInterval.Value) - DateTime.Now;
            this.LblNextUpdate.Text = timeLeft.Seconds.ToString() + "s";
        }

        private void Start()
        {
            // Check inputs
            try
            {
                if (!new FileInfo(this.TxtDatabaseFilepath.Text).Exists)
                {
                    MessageBox.Show("Die Datenbank " + this.TxtDatabaseFilepath.Text + " wurde nicht gefunden.", "TsDataServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!new FileInfo(this.TxtJsonFilePath.Text).Directory.Exists)
                {
                    MessageBox.Show("Ungültiger Pfad: " + this.TxtJsonFilePath.Text, "TsDataServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups, da ging etwas schief:\r\n\r\n" + ex, "TsDataServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect database
            try
            {
                this.tsAdapter.Connect(this.TxtDatabaseFilepath.Text);
                this.LblStatusDatabase.Text = "Verbunden";
                this.LblStatusDatabase.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden der Datenbank:\r\n\r\n" + ex, "TsDataServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect the rabbit
            if (this.ChbRabbit.Checked)
            {
                try
                {
                    this.rabbitAdapter = new RabbitAdapter(this.TxtRabbitServer.Text, this.TxtRabbitVhost.Text, this.TxtRabbitUser.Text, this.TxtRabbitPassword.Text);
                    this.LblStatusRabbit.Text = "Verbunden";
                    this.LblStatusRabbit.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Verbindung zu RabbitMQ Server fehlgeschlagen:\r\n\r\n" + ex, "TsDataServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Set and start timer
            this.TmrUpdater.Interval = (int)this.NudInterval.Value * 1000;
            this.LblNextUpdate.Text = this.NudInterval.Value + "s";
            this.LoadMatches();
            this.TmrUpdater.Start();
            this.TmrCountdown.Start();
            this.BtnStartAutoUpdate.Enabled = false;
            this.BtnStopAutoupdate.Enabled = true;
        }

        private void LoadMatches()
        {
            // Load current matches
            var currentMatches = this.tsAdapter.GetCurrentMatches();
            this.LvwCurrentMatches.BeginUpdate();
            this.LvwCurrentMatches.Items.Clear();
            foreach (var match in currentMatches)
            {
                var item = new ListViewItem(match.Court.ToString());
                item.SubItems.Add(match.PlanDate.ToString());
                item.SubItems.Add(match.Team1.ToStringShort());
                item.SubItems.Add(match.Team2.ToStringShort());
                item.SubItems.Add(match.Draw.Name);
                item.SubItems.Add(match.Roundnr.ToString());
                this.LvwCurrentMatches.Items.Add(item);
            }

            this.LvwCurrentMatches.EndUpdate();

            // Load planned matches
            var plannedMatches = this.tsAdapter.GetPlannedMatches();
            plannedMatches.Sort(SortingHelper.CompareOrder);

            // Load counting and ready matches            
            this.LvwCounting.BeginUpdate();
            this.LvwReady.BeginUpdate();
            this.LvwCounting.Items.Clear();
            this.LvwReady.Items.Clear();

            for (var i = 1; i <= 8; i++) // TODO: Make court count dynamic
            {
                var courtMatches = plannedMatches.FindAll(x => x.Court == i);
                if (courtMatches.Count >= 1)
                {
                    var item = new ListViewItem(courtMatches[0].Court.ToString());
                    item.SubItems.Add(courtMatches[0].PlanDate.ToString());
                    item.SubItems.Add(courtMatches[0].Team1.ToStringShort());
                    item.SubItems.Add(courtMatches[0].Team2.ToStringShort());
                    item.SubItems.Add(courtMatches[0].Draw.Name);
                    item.SubItems.Add(courtMatches[0].Roundnr.ToString());
                    item.SubItems.Add(courtMatches[0].Draw.TypeName);
                    this.LvwCounting.Items.Add(item);
                }

                if (courtMatches.Count >= 2)
                {
                    var item = new ListViewItem(courtMatches[1].Court.ToString());
                    item.SubItems.Add(courtMatches[1].PlanDate.ToString());
                    item.SubItems.Add(courtMatches[1].Team1.ToStringShort());
                    item.SubItems.Add(courtMatches[1].Team2.ToStringShort());
                    item.SubItems.Add(courtMatches[1].Draw.Name);
                    item.SubItems.Add(courtMatches[1].Roundnr.ToString());
                    item.SubItems.Add(courtMatches[1].Draw.TypeName);
                    this.LvwReady.Items.Add(item);
                }
            }

            this.LvwCounting.EndUpdate();
            this.LvwReady.EndUpdate();

            // Create and send payload to rabbit
            if (this.ChbRabbit.Checked)
            {
                var messagePayload = new MatchesPayload { CurrentMatches = currentMatches, PlannedMatches = plannedMatches, Timestamp = DateTime.Now };
                this.rabbitAdapter.Send(messagePayload);
            }

            // Create and send payload to rabbit
            if (this.ChbJson.Checked)
            {
                try
                {
                    var messagePayload = new MatchesPayload { CurrentMatches = currentMatches, PlannedMatches = plannedMatches, Timestamp = DateTime.Now };
                    var json = JsonConvert.SerializeObject(messagePayload);
                    File.WriteAllText(this.TxtJsonFilePath.Text, json);
                }
                catch
                {
                    // Swallow it...
                }
            }

            this.lastUpdate = DateTime.Now;
        }

        private void Stop()
        {
            this.TmrCountdown.Stop();
            this.TmrUpdater.Stop();
            this.BtnStartAutoUpdate.Enabled = true;
            this.BtnStopAutoupdate.Enabled = false;
                        
            this.tsAdapter.Close();
            if (this.rabbitAdapter != null)
            {
                this.rabbitAdapter.Close();
            }

            this.LblStatusDatabase.Text = "Nicht verbunden";
            this.LblStatusDatabase.ForeColor = Color.Red;

            this.LblStatusRabbit.Text = "Nicht verbunden";
            this.LblStatusRabbit.ForeColor = Color.Red;

            this.LblNextUpdate.Text = "--s";

            this.LvwCurrentMatches.Items.Clear();
            this.LvwCounting.Items.Clear();
            this.LvwReady.Items.Clear();
        }

        private void BtnOpenDatabase_Click(object sender, EventArgs e)
        {
            if (this.OfdDatabase.ShowDialog() == DialogResult.OK)
            {
                this.TxtDatabaseFilepath.Text = this.OfdDatabase.FileName;
            }
        }

        private void ChbRabbit_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtRabbitServer.Enabled = this.ChbRabbit.Checked;
            this.TxtRabbitVhost.Enabled = this.ChbRabbit.Checked;
            this.TxtRabbitUser.Enabled = this.ChbRabbit.Checked;
            this.TxtRabbitPassword.Enabled = this.ChbRabbit.Checked;
        }

        private void BtnOpenJson_Click(object sender, EventArgs e)
        {
            if (this.SfdJson.ShowDialog() == DialogResult.OK)
            {
                this.TxtJsonFilePath.Text = this.SfdJson.FileName;
            }
        }
    }
}
