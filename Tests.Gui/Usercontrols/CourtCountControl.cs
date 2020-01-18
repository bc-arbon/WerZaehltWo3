namespace BCA.WerZaehltWo3.Tests.Gui.Usercontrols
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using BCA.WerZaehltWo3.Forms;    

    public partial class CourtCountControl : UserControl
    {
        public CourtCountControl()
        {
            this.InitializeComponent();
        }

        private void BtnCourtCount_Click(object sender, EventArgs e)
        {
            var courtCountForm = new FrmCourtCount();
            courtCountForm.SetData(Convert.ToInt32(this.lblCourtCount.Text));
            if (courtCountForm.ShowDialog() == DialogResult.OK)
            {
                this.lblCourtCount.Text = courtCountForm.CourtCount.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}