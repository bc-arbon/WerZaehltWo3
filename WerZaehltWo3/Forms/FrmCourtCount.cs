using System;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmCourtCount : FrmBase
    {
        public FrmCourtCount()
        {
            this.InitializeComponent();
        }

        public int CourtCount { get; private set; }

        public void SetData(int courtCount)
        {
            this.CourtCount = courtCount;
            this.nudCourtCount.Value = courtCount;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.CourtCount = Convert.ToInt32(this.nudCourtCount.Value);
        }
    }
}