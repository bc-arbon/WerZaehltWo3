using BCA.WerZaehltWo3.Forms;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using System;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Tests.Gui.Usercontrols
{
    public partial class PlayerEditorControl : UserControl
    {
        private readonly Playerboard playerboard = new Playerboard();

        public PlayerEditorControl()
        {
            this.InitializeComponent();
        }

        private void BtnNewPlayer_Click(object sender, EventArgs e)
        {
            var playerEditor = new FrmPlayerEditor();
            if (playerEditor.ShowDialog() == DialogResult.OK)
            {
                this.lblName.Text = playerEditor.Player;
            }
        }

        private void BtnEditPlayer_Click(object sender, EventArgs e)
        {
            var player = this.lblName.Text;
            var playerEditor = new FrmPlayerEditor();
            playerEditor.SetData(player);

            if (playerEditor.ShowDialog() == DialogResult.OK)
            {
                this.lblName.Text = playerEditor.Player;
            }
        }

        private void BtnPlayers_Click(object sender, EventArgs e)
        {
            var playerForm = new FrmPlayer(this.playerboard);
            playerForm.ShowDialog();
        }
    }
}