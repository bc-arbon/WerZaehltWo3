using BCA.WerZaehltWo3.Common.Adapters;
using BCA.WerZaehltWo3.Common.TournamentSoftware;
using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmTsMonitor : Form
    {
        public FrmTsMonitor()
        {
            this.InitializeComponent();
        }

        public FrmTsMonitor(AppSettings appSettings) : this()
        {
            if (appSettings == null) { throw new ArgumentNullException(nameof(appSettings)); }

            this.appSettings = appSettings;
        }

        private readonly AppSettings appSettings;
        private readonly TsDatabaseAdapter tsAdapter = new TsDatabaseAdapter();
        private RabbitAdapter rabbitAdapter;
        private DateTime lastUpdate;

        private void FrmTsData_Load(object sender, EventArgs e)
        {
            this.TxtJsonFilePath.Text = this.appSettings.TsJsonFilePath;
            this.TxtRabbitServer.Text = this.appSettings.RabbitServer;
            this.TxtRabbitUser.Text = this.appSettings.RabbitUser;
            this.TxtRabbitPassword.Text = this.appSettings.RabbitPassword;
            this.TxtRabbitVhost.Text = this.appSettings.RabbitVhost;
            this.NudInterval.Value = this.appSettings.TsMonitorInterval;
        }

        private void FrmTsMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't close it, hide it insteand. Preventing it from disposing
            e.Cancel = true;
            this.Hide();
        }

        private void BtnOpenDatabase_Click(object sender, EventArgs e)
        {
            if (this.OfdJason.ShowDialog() == DialogResult.OK)
            {
                this.TxtJsonFilePath.Text = this.OfdJason.FileName;
            }
        }

        private void ChbRabbit_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtRabbitServer.Enabled = this.ChbRabbit.Checked;
            this.TxtRabbitVhost.Enabled = this.ChbRabbit.Checked;
            this.TxtRabbitUser.Enabled = this.ChbRabbit.Checked;
            this.TxtRabbitPassword.Enabled = this.ChbRabbit.Checked;
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

        private void LoadMatches()
        {
            if (!File.Exists(this.TxtJsonFilePath.Text))
            {
                return;
            }

            var json = File.ReadAllText(this.TxtJsonFilePath.Text);
            var matches = JsonConvert.DeserializeObject<MatchesPayload>(json);
                        

            // Load current matches
            this.LvwPlay.BeginUpdate();
            this.LvwPlay.Items.Clear();
            foreach (var match in matches.CurrentMatches)
            {
                var item = new ListViewItem(match.Court.ToString());
                item.SubItems.Add(match.PlanDate.ToString());
                item.SubItems.Add(match.Team1.ToStringShort());
                item.SubItems.Add(match.Team2.ToStringShort());
                item.SubItems.Add(match.Draw.Name);
                item.SubItems.Add(match.Roundnr >= 1 ? match.Roundnr.ToString() : string.Empty);
                item.SubItems.Add(match.Draw.TypeName);
                this.LvwPlay.Items.Add(item);
            }

            this.LvwPlay.EndUpdate();

            // Load counting and ready matches            
            this.LvwCounting.BeginUpdate();
            this.LvwReady.BeginUpdate();
            this.LvwCounting.Items.Clear();
            this.LvwReady.Items.Clear();

            for (var i = 1; i <= this.appSettings.CourtCount; i++)
            {
                var courtMatches = matches.PlannedMatches.FindAll(x => x.Court == i);
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

            this.lastUpdate = DateTime.Now;
        }

        private void Start()
        {
            // Save settings
            this.appSettings.RabbitServer = this.TxtRabbitUser.Text;
            this.appSettings.RabbitVhost = this.TxtRabbitVhost.Text;
            this.appSettings.RabbitUser = this.TxtRabbitUser.Text;
            this.appSettings.RabbitPassword = this.TxtRabbitPassword.Text;
            this.appSettings.TsMonitorInterval = (int)this.NudInterval.Value;
            this.appSettings.TsJsonFilePath = this.TxtJsonFilePath.Text;
            AppSettingsLogic.Save(this.appSettings);

            // Connect database
            try
            {
                var json = File.ReadAllText(this.TxtJsonFilePath.Text);
                this.LblStatusJson.Text = "Verbunden";
                this.LblStatusJson.ForeColor = Color.Green;
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

            this.LblStatusJson.Text = "Nicht verbunden";
            this.LblStatusJson.ForeColor = Color.Red;

            this.LblStatusRabbit.Text = "Nicht verbunden";
            this.LblStatusRabbit.ForeColor = Color.Red;

            this.LblNextUpdate.Text = "--s";

            this.LvwPlay.Items.Clear();
            this.LvwCounting.Items.Clear();
        }       
    }
}
