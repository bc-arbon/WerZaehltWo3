using System;
using System.Windows.Forms;
using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmPlayer : FrmBase
    {
        private readonly Playerboard playerboard;

        public FrmPlayer(Playerboard playerboard)
        {
            this.InitializeComponent();
            this.playerboard = playerboard;
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            this.PopulateListview();
        }

        private void LvwPlayers_DoubleClick(object sender, EventArgs e)
        {
            this.EditPlayer();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.AddPlayer();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.EditPlayer();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.DeletePlayers();
        }

        private void PopulateListview()
        {
            this.lvwPlayers.Items.Clear();
            foreach (var player in this.playerboard.Players)
            {
                var item = new ListViewItem(player);
                item.Tag = player;
                this.lvwPlayers.Items.Add(item);
            }
        }

        private void AddPlayer()
        {
            var playerEditorForm = new FrmPlayerEditor();

            if (playerEditorForm.ShowDialog() == DialogResult.OK)
            {
                var newPlayer = playerEditorForm.Player;
                PlayerboardLogic.AddPlayer(this.playerboard, newPlayer);
                PlayerboardLogic.Save(this.playerboard);
                this.PopulateListview();
            }

        }

        private void EditPlayer()
        {
            if (this.lvwPlayers.SelectedItems.Count == 1)
            {
                var oldPlayer = this.lvwPlayers.SelectedItems[0].Text;
                var editor = new FrmPlayerEditor();
                editor.SetData(oldPlayer);

                if (editor.ShowDialog() == DialogResult.OK)
                {
                    var newPlayer = editor.Player;
                    PlayerboardLogic.UpdatePlayer(this.playerboard, oldPlayer, newPlayer);
                    PlayerboardLogic.Save(this.playerboard);
                    this.PopulateListview();
                }
            }
        }

        private void DeletePlayers()
        {
            if (this.lvwPlayers.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(this.lvwPlayers.SelectedItems.Count + " Spieler löschen?", "Spielereditor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var player = this.lvwPlayers.SelectedItems[0].Text;
                    PlayerboardLogic.RemovePlayer(this.playerboard, player);
                    PlayerboardLogic.Save(this.playerboard);
                    this.PopulateListview();
                }
            }
        }

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

        private void BtnImportTs_Click(object sender, EventArgs e)
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