namespace BCA.WerZaehltWo3.Forms
{
    using System;

    public partial class FrmCourtCount : FrmBase
    {
        private int courtCount;

        public FrmCourtCount()
        {
            this.InitializeComponent();
        }

        public int CourtCount
        {
            get { return this.courtCount; }
        }

        public void SetData(int courtCount)
        {
            this.courtCount = courtCount;
            this.nudCourtCount.Value = courtCount;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.courtCount = Convert.ToInt32(this.nudCourtCount.Value);
        }
    }
}