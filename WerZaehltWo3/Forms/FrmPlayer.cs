﻿using System;
using System.Windows.Forms;

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
            var playerEditorForm = new FrmPlayerEditor();
            if (playerEditorForm.ShowDialog() == DialogResult.OK)
            {
                this.playerboard.Players.Add(playerEditorForm.Player.Clone());
            }

            this.PopulateListview();
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
                var item = new ListViewItem(player.Id);
                item.SubItems.Add(player.Name);
                item.SubItems.Add(player.Category);
                item.SubItems.Add(player.Club);
                item.Tag = player;
                this.lvwPlayers.Items.Add(item);
            }
        }

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