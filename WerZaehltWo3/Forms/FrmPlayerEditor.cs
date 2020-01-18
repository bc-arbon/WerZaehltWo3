namespace BCA.WerZaehltWo3.Forms
{
    using BCA.WerZaehltWo3.ObjectModel;
    using System;
    
    public partial class FrmPlayerEditor : FrmBase
    {
        public FrmPlayerEditor()
        {
            this.InitializeComponent();
        }

        public Player Player { get; private set; }

        public void SetData(Player playerData)
        {
            this.Player = playerData;
            this.txtName.Text = this.Player.Name;
            this.txtClub.Text = this.Player.Club;
            this.txtCategory.Text = this.Player.Category;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.Player == null)
            {
                this.Player = new Player();
            }

            this.Player.Name = this.txtName.Text;
            this.Player.Club = this.txtClub.Text;
            this.Player.Category = this.txtCategory.Text;
        }
    }
}