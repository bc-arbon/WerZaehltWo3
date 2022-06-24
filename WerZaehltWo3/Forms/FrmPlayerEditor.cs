using System;
using System.Windows.Forms;

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
            this.TxtName.Text = this.Player;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Player = this.TxtName.Text;
        }

        private void TxtName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Player = this.TxtName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}