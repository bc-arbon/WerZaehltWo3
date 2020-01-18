namespace BCA.WerZaehltWo3.Forms
{
    using System;

    public partial class FrmCourtCount : FrmBase
    {
        /// <summary>
        /// The court count
        /// </summary>
        private int courtCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCourtCount" /> class.
        /// </summary>
        public FrmCourtCount()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the court count.
        /// </summary>
        public int CourtCount
        {
            get { return this.courtCount; }
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="courtCount">The court count.</param>
        public void SetData(int courtCount)
        {
            this.courtCount = courtCount;
            this.nudCourtCount.Value = courtCount;
        }

        /// <summary>
        /// Handles the Click event of the BtnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.courtCount = Convert.ToInt32(this.nudCourtCount.Value);
        }
    }
}