using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WerZaehltWo3.Wpf.Forms
{
    /// <summary>
    /// Interaction logic for FrmPlayers.xaml
    /// </summary>
    public partial class FrmPlayers : Window
    {
        private readonly Playerboard playerboard;

        public FrmPlayers()
        {
            this.InitializeComponent();
        }

        public FrmPlayers(Playerboard playerboard) : this()
        {
            this.playerboard = playerboard;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.PopulateListview();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            //var playerEditorForm = new FrmPlayerEditor();
            //if (playerEditorForm.ShowDialog() == DialogResult.OK)
            //{
            //    this.playerboard.Players.Add(playerEditorForm.Player.Clone());
            //}

            this.PopulateListview();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            this.EditPlayer();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            this.DeletePlayers();
        }

        private void PopulateListview()
        {
            this.LvwPlayers.Items.Clear();
            foreach (var player in this.playerboard.Players)
            {                
                this.LvwPlayers.Items.Add(player);
            }
        }

        private void EditPlayer()
        {
            //if (this.lvwPlayers.SelectedItems.Count == 1)
            //{
            //    var player = (Player)this.lvwPlayers.SelectedItems[0].Tag;
            //    var editor = new FrmPlayerEditor();
            //    editor.SetData(player);
            //    if (editor.ShowDialog() == DialogResult.OK)
            //    {
            //        this.PopulateListview();
            //    }
            //}
        }

        private void DeletePlayers()
        {
            //if (this.lvwPlayers.SelectedItems.Count > 0)
            //{
            //    if (MessageBox.Show(this.lvwPlayers.SelectedItems.Count + " Spieler löschen?", "Spielereditor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    {
            //        foreach (ListViewItem item in this.lvwPlayers.SelectedItems)
            //        {
            //            var player1 = (Player)item.Tag;
            //            foreach (var player2 in this.playerboard.Players)
            //            {
            //                if (player1.Id == player2.Id)
            //                {
            //                    this.playerboard.Players.Remove(player2);
            //                    break;
            //                }
            //            }
            //        }

            //        this.PopulateListview();
            //    }
            //}
        }
    }
}
