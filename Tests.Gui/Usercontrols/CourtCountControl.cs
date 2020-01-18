namespace BCA.WerZaehltWo3.Tests.Gui.Usercontrols
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using BCA.WerZaehltWo3.Forms;    

    /// <summary>
    /// CourtCountControl class
    /// </summary>
    public partial class CourtCountControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CourtCountControl"/> class.
        /// </summary>
        public CourtCountControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the BtnCourtCount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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