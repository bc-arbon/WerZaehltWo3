using System;
    
namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmPlayerEditor : FrmBase
    {
        public FrmPlayerEditor()
        {
            this.InitializeComponent();
        }

        public string Player { get; private set; }

        public void SetData(string playerData)
        {
            this.Player = playerData;
            this.txtName.Text = this.Player;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Player = this.txtName.Text;
        }
    }
}