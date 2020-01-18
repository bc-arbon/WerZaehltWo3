namespace BCA.WerZaehltWo3.Forms
{
    using BCA.WerZaehltWo3.ObjectModel;
    using System;
    
    /// <summary>
    /// PlayerEditorForm class
    /// </summary>
    public partial class FrmPlayerEditor : FrmBase
    {
        /// <summary>
        /// The player
        /// </summary>
        private Player player;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmPlayerEditor"/> class.
        /// </summary>
        public FrmPlayerEditor()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the player.
        /// </summary>
        public Player Player
        {
            get
            {
                return this.player;
            }
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="playerData">The player data.</param>
        public void SetData(Player playerData)
        {
            this.player = playerData;
            this.txtName.Text = this.player.Name;
            this.txtClub.Text = this.player.Club;
            this.txtCategory.Text = this.player.Category;
        }

        /// <summary>
        /// Handles the Click event of the BtnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.player == null)
            {
                this.player = new Player();
            }

            this.player.Name = this.txtName.Text;
            this.player.Club = this.txtClub.Text;
            this.player.Category = this.txtCategory.Text;
        }
    }
}