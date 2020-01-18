namespace BCA.WerZaehltWo3.Tests.Gui.Usercontrols
{
    using BCA.WerZaehltWo3.Forms;
    using BCA.WerZaehltWo3.ObjectModel;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// PlayerEditorControl class
    /// </summary>
    public partial class PlayerEditorControl : UserControl
    {
        /// <summary>
        /// The playerboard
        /// </summary>
        private readonly Playerboard playerboard = new Playerboard();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerEditorControl"/> class.
        /// </summary>
        public PlayerEditorControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the BtnNewPlayer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnNewPlayer_Click(object sender, EventArgs e)
        {
            var playerEditor = new FrmPlayerEditor();
            if (playerEditor.ShowDialog() == DialogResult.OK)
            {
                this.lblName.Text = playerEditor.Player.Name;
                this.lblClub.Text = playerEditor.Player.Club;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnEditPlayer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnEditPlayer_Click(object sender, EventArgs e)
        {
            var player = new Player { Name = this.lblName.Text, Club = this.lblClub.Text };
            var playerEditor = new FrmPlayerEditor();
            playerEditor.SetData(player);

            if (playerEditor.ShowDialog() == DialogResult.OK)
            {
                this.lblName.Text = playerEditor.Player.Name;
                this.lblClub.Text = playerEditor.Player.Club;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnPlayers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnPlayers_Click(object sender, EventArgs e)
        {
            var playerForm = new FrmPlayer(this.playerboard);
            playerForm.ShowDialog();
        }
    }
}
