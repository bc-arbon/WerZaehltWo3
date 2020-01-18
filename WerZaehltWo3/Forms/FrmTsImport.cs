namespace BCA.WerZaehltWo3.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using BCA.WerZaehltWo3.Adapters;
    using BCA.WerZaehltWo3.ObjectModel;

    /// <summary>
    /// BadmanImportForm class
    /// </summary>
    public partial class FrmTsImport : FrmBase
    {
        /// <summary>
        /// The adapter
        /// </summary>
        private readonly TsDatabaseAdapter adapter = new TsDatabaseAdapter();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmTsImport"/> class.
        /// </summary>
        public FrmTsImport()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the imported players.
        /// </summary>
        public List<Player> ImportedPlayers { get; set; }

        /// <summary>
        /// Handles the Load event of the BadmanImportForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TsImportForm_Load(object sender, EventArgs e)
        {
            ////this.txtDatabaseFilepath.Text = Settings.Default.BadmanDatabaseFilepath;
        }

        /// <summary>
        /// Handles the FormClosing event of the BadmanImportForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the BtnConnect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the BtnOpenDatabase control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnOpenDatabase_Click(object sender, EventArgs e)
        {
            if (this.ofdBadmanDatabase.ShowDialog() == DialogResult.OK)
            {
                this.txtDatabaseFilepath.Text = this.ofdBadmanDatabase.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnGetPlayers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGetPlayers_Click(object sender, EventArgs e)
        {
            
                this.btnGetPlayers.Text = "Laden...";
                this.EnableDisable(true);
                this.bgwWorker.RunWorkerAsync();
            
        }

        /// <summary>
        /// Handles the Click event of the BtnImport control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnImport_Click(object sender, EventArgs e)
        {
            this.ImportedPlayers = new List<Player>();
            foreach (ListViewItem item in this.lvwPlayers.Items)
            {
                this.ImportedPlayers.Add((Player)item.Tag);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the BgwWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs" /> instance containing the event data.</param>
        private void BgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var players = this.adapter.GetPlayers();

            this.lvwPlayers.Items.Clear();
            foreach (var player in players)
            {
                this.bgwWorker.ReportProgress(0, player);
            }
        }

        /// <summary>
        /// Handles the ProgressChanged event of the BgwWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.ProgressChangedEventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the RunWorkerCompleted event of the BgwWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs" /> instance containing the event data.</param>
        private void BgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnGetPlayers.Text = "Teilnehmer anzeigen";
            this.EnableDisable(false);
            this.adapter.Close();
        }

        /// <summary>
        /// Enables the disable.
        /// </summary>
        /// <param name="workerisBusy">if set to <c>true</c> [workeris busy].</param>
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