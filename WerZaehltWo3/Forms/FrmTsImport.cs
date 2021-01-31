using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BCA.WerZaehltWo3.Shared.Adapters;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmTsImport : FrmBase
    {
        private readonly TsDatabaseAdapter adapter = new TsDatabaseAdapter();

        public FrmTsImport()
        {
            this.InitializeComponent();
        }

        public List<string> ImportedPlayers { get; set; }

        private void TsImportForm_Load(object sender, EventArgs e)
        {
            //this.txtDatabaseFilepath.Text = Settings.Default.BadmanDatabaseFilepath;
        }

        private void TsImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bgwWorker.IsBusy)
            {
                e.Cancel = true;
            }

            this.adapter.Close();
            // TODO
            //Settings.Default.BadmanDatabaseFilepath = this.txtDatabaseFilepath.Text;
            //Settings.Default.Save();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDatabaseFilepath.Text))
            {
                return;
            }

            try
            {
                this.adapter.Connect(this.txtDatabaseFilepath.Text);
                this.btnGetPlayers.Enabled = true;
                MessageBox.Show("Verbunden", "Spieler importieren", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Spieler importieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOpenDatabase_Click(object sender, EventArgs e)
        {
            if (this.ofdBadmanDatabase.ShowDialog() == DialogResult.OK)
            {
                this.txtDatabaseFilepath.Text = this.ofdBadmanDatabase.FileName;
            }
        }

        private void BtnGetPlayers_Click(object sender, EventArgs e)
        {
            
                this.btnGetPlayers.Text = "Laden...";
                this.EnableDisable(true);
                this.bgwWorker.RunWorkerAsync();
            
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            this.ImportedPlayers = new List<string>();
            foreach (ListViewItem item in this.lvwPlayers.Items)
            {
                this.ImportedPlayers.Add(item.ToString());
            }
        }

        private void BgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var players = this.adapter.GetPlayers();

            this.lvwPlayers.Items.Clear();
            foreach (var player in players)
            {
                this.bgwWorker.ReportProgress(0, player);
            }
        }

        private void BgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var player = e.UserState.ToString();
            var item = new ListViewItem(player);
            this.lvwPlayers.Items.Add(item);
        }

        private void BgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnGetPlayers.Text = "Teilnehmer anzeigen";
            this.EnableDisable(false);
            this.adapter.Close();
        }

        private void EnableDisable(bool workerisBusy)
        {
            this.txtDatabaseFilepath.Enabled = !workerisBusy;
            this.btnOpenDatabase.Enabled = !workerisBusy;
            this.btnConnect.Enabled = !workerisBusy;
            this.btnGetPlayers.Enabled = !workerisBusy;
            this.btnCancel.Enabled = !workerisBusy;
        }
    }
}