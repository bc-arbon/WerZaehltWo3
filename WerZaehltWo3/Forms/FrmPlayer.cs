namespace BCA.WerZaehltWo3.Forms
{
    using System;
    using System.Windows.Forms;

    using BCA.WerZaehltWo3.ObjectModel;

    /// <summary>
    /// PlayerForm class
    /// </summary>
    public partial class FrmPlayer : FrmBase
    {
        /// <summary>
        /// The playerboard
        /// </summary>
        private readonly Playerboard playerboard;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmPlayer" /> class.
        /// </summary>
        /// <param name="playerboard">The playerboard.</param>
        public FrmPlayer(Playerboard playerboard)
        {
            this.InitializeComponent();
            this.playerboard = playerboard;
        }

        /// <summary>
        /// Handles the Load event of the PlayerForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void PlayerForm_Load(object sender, EventArgs e)
        {
            this.PopulateListview();
        }

        /// <summary>
        /// Handles the DoubleClick event of the LvwPlayers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void LvwPlayers_DoubleClick(object sender, EventArgs e)
        {
            this.EditPlayer();
        }

        /// <summary>
        /// Handles the Click event of the BtnNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            var playerEditorForm = new FrmPlayerEditor();
            if (playerEditorForm.ShowDialog() == DialogResult.OK)
            {
                this.playerboard.Players.Add(playerEditorForm.Player.Clone());
            }

            this.PopulateListview();
        }

        /// <summary>
        /// Handles the Click event of the BtnEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.EditPlayer();
        }

        /// <summary>
        /// Handles the Click event of the BtnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.DeletePlayers();
        }

        /// <summary>
        /// Populates the listview.
        /// </summary>
        private void PopulateListview()
        {
            this.lvwPlayers.Items.Clear();
            foreach (var player in this.playerboard.Players)
            {
                var item = new ListViewItem(player.Id);
                item.SubItems.Add(player.Name);
                item.SubItems.Add(player.Category);
                item.SubItems.Add(player.Club);
                item.Tag = player;
                this.lvwPlayers.Items.Add(item);
            }
        }

        /// <summary>
        /// Edits the player.
        /// </summary>
        private void EditPlayer()
        {
            if (this.lvwPlayers.SelectedItems.Count == 1)
            {
                var player = (Player)this.lvwPlayers.SelectedItems[0].Tag;
                var editor = new FrmPlayerEditor();
                editor.SetData(player);
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    this.PopulateListview();
                }
            }
        }

        /// <summary>
        /// Deletes the players.
        /// </summary>
        private void DeletePlayers()
        {
            if (this.lvwPlayers.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(this.lvwPlayers.SelectedItems.Count + " Spieler löschen?", "Spielereditor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (ListViewItem item in this.lvwPlayers.SelectedItems)
                    {
                        var player1 = (Player)item.Tag;
                        foreach (var player2 in this.playerboard.Players)
                        {
                            if (player1.Id == player2.Id)
                            {
                                this.playerboard.Players.Remove(player2);
                                break;
                            }
                        }
                    }

                    this.PopulateListview();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnImport control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnImportBadman_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Achtung: Alle bestehenden Spieler werden dadurch gelöscht. Fortfahren?",
                "Importieren",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            var importForm = new FrmBadmanImport();
            if (importForm.ShowDialog() == DialogResult.OK)
            {
                this.playerboard.Players.Clear();
                this.playerboard.Players.AddRange(importForm.ImportedPlayers);
                this.PopulateListview();
            }
        }

        private void btnImportTs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Achtung: Alle bestehenden Spieler werden dadurch gelöscht. Fortfahren?",
                "Importieren",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            var importForm = new FrmTsImport();
            if (importForm.ShowDialog() == DialogResult.OK)
            {
                this.playerboard.Players.Clear();
                this.playerboard.Players.AddRange(importForm.ImportedPlayers);
                this.PopulateListview();
            }
        }
    }
}