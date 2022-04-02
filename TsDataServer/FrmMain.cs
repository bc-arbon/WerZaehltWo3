using BCA.WerZaehltWo3.Common.Adapters;
using BCA.WerZaehltWo3.Shared.Adapters;
using System;
using System.Diagnostics;
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
                this.TxtDatabaseFilepath.Text = this.appSettings.Database;
                this.TxtRabbitServer.Text = this.appSettings.RabbitServer;
                this.TxtRabbitUser.Text = this.appSettings.RabbitUser;
                this.TxtRabbitPassword.Text = this.appSettings.RabbitPassword;
                this.TxtRabbitVhost.Text = this.appSettings.RabbitVhost;
                this.NudInterval.Value = this.appSettings.Interval;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.appSettings.Database = this.TxtDatabaseFilepath.Text;
            this.appSettings.RabbitServer = this.TxtRabbitServer.Text;
            this.appSettings.RabbitVhost = this.TxtRabbitVhost.Text;
            this.appSettings.RabbitUser = this.TxtRabbitUser.Text;
            this.appSettings.RabbitPassword = this.TxtRabbitPassword.Text;
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

            // Connect to rabbitmq
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

            // Set and start timer
            this.TmrUpdater.Interval = (int)this.NudInterval.Value * 1000;
            this.LoadMatches();
            this.TmrUpdater.Start();
            this.TmrCountdown.Start();
            this.BtnStartAutoUpdate.Enabled = false;
            this.BtnStopAutoupdate.Enabled = true;
        }

        private void BtnStopAutoupdate_Click(object sender, EventArgs e)
        {
            this.TmrCountdown.Stop();
            this.TmrUpdater.Stop();
            this.BtnStartAutoUpdate.Enabled = true;
            this.BtnStopAutoupdate.Enabled = false;

            this.tsAdapter.Close();
            this.rabbitAdapter.Close();

            this.LblStatusDatabase.Text = "Nicht verbunden";
            this.LblStatusDatabase.ForeColor = Color.Red;

            this.LblStatusRabbit.Text = "Nicht verbunden";
            this.LblStatusRabbit.ForeColor = Color.Red;

            this.LblNextUpdate.Text = "--s";

            this.LvwCurrentMatches.Items.Clear();
            this.LvwPlannedMatches.Items.Clear();
        }

        private void TmrUpdater_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine("tmrUpdate_Tick");
            this.LoadMatches();
        }

        private void TmrCountdown_Tick(object sender, EventArgs e)
        {            
            var timeLeft = this.lastUpdate.AddSeconds((int)this.NudInterval.Value) - DateTime.Now;
            //Debug.WriteLine("Timelft: " + timeLeft);
            this.LblNextUpdate.Text = timeLeft.Seconds.ToString() + "s";
        }

        private void LoadMatches()
        {
            //Debug.WriteLine("Load matches");
            var currentMatches = this.tsAdapter.GetCurrentMatches();

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

            var plannedMatches = this.tsAdapter.GetPlannedMatches();
            this.LvwPlannedMatches.Items.Clear();
            foreach (var match in plannedMatches)
            {
                var item = new ListViewItem(match.Court.ToString());
                item.SubItems.Add(match.PlanDate.ToString());
                item.SubItems.Add(match.Team1.ToStringShort());
                item.SubItems.Add(match.Team2.ToStringShort());
                item.SubItems.Add(match.Draw.Name);
                item.SubItems.Add(match.Roundnr.ToString());
                this.LvwPlannedMatches.Items.Add(item);
            }

            this.lastUpdate = DateTime.Now;
        }
    }
}
