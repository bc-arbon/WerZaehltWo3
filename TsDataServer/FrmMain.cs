using BCA.WerZaehltWo3.Common.Adapters;
using BCA.WerZaehltWo3.Shared.Adapters;
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
        }
    }
}
