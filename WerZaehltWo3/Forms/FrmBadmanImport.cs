namespace BCA.WerZaehltWo3.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;

    using BCA.WerZaehltWo3.ObjectModel;
    using BCA.WerZaehltWo3.Adapters;

    public partial class FrmBadmanImport : FrmBase
    {
        private readonly BadmanDatabaseAdapter adapter = new BadmanDatabaseAdapter();

        public FrmBadmanImport()
        {
            this.InitializeComponent();
        }

        public List<Player> ImportedPlayers { get; set; }

        private void BadmanImportForm_Load(object sender, EventArgs e)
        {
            // TODO
            //this.txtDatabaseFilepath.Text = Settings.Default.BadmanDatabaseFilepath;
        }

        private void BadmanImportForm_FormClosing(object sender, FormClosingEventArgs e)
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
                var tournaments = this.adapter.GetTournaments();

                this.cbxTournaments.Items.Clear();
                foreach (var tournament in tournaments)
                {
                    this.cbxTournaments.Items.Add(tournament);
                }

                this.cbxTournaments.Enabled = this.cbxTournaments.Items.Count > 0;
                this.btnGetPlayers.Enabled = this.cbxTournaments.Items.Count > 0;

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
            if (this.cbxTournaments.SelectedItem != null)
            {
                this.btnGetPlayers.Text = "Laden...";
                this.EnableDisable(true);
                this.bgwWorker.RunWorkerAsync(this.cbxTournaments.SelectedItem.ToString());
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            this.ImportedPlayers = new List<Player>();
            foreach (ListViewItem item in this.lvwPlayers.Items)
            {
                this.ImportedPlayers.Add((Player)item.Tag);
            }
        }

        private void BgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var players = this.adapter.GetPlayers(e.Argument.ToString());

            this.lvwPlayers.Items.Clear();
            foreach (var player in players)
            {
                this.bgwWorker.ReportProgress(0, player);
            }
        }

        private void BgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var player = (Player)e.UserState;
            var item = new ListViewItem(player.Id);
            item.SubItems.Add(player.Name);
            item.SubItems.Add(player.Club);
            item.SubItems.Add(player.Category);
            item.Tag = player;
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
            this.cbxTournaments.Enabled = !workerisBusy;
            this.txtDatabaseFilepath.Enabled = !workerisBusy;
            this.btnOpenDatabase.Enabled = !workerisBusy;
            this.btnConnect.Enabled = !workerisBusy;
            this.btnGetPlayers.Enabled = !workerisBusy;
            this.btnCancel.Enabled = !workerisBusy;
        }
    }
}