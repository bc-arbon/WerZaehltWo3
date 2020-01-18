namespace BCA.WerZaehltWo3.Forms
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    using BCA.WerZaehltWo3.Logic;
    using BCA.WerZaehltWo3.Usercontrols;
    using BCA.WerZaehltWo3.ObjectModel;

    /// <summary>
    /// DisplayForm class
    /// </summary>
    public partial class FrmDisplay : Form
    {
        /// <summary>
        /// The brush
        /// </summary>
        private LinearGradientBrush brush;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmDisplay"/> class.
        /// </summary>
        public FrmDisplay()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the playerboard manager.
        /// </summary>
        public PlayerboardManager PlayerboardManager { get; set; }

        /// <summary>
        /// Updates the display controls.
        /// </summary>
        public void InitializeDisplayControls()
        {
            this.pnlControl.Controls.Clear();
            foreach (var court in this.PlayerboardManager.Playerboard.Courts)
            {
                var settingsControl = new CourtDisplayControl();
                settingsControl.SetData(court);
                this.pnlControl.Controls.Add(settingsControl);
            }
        }

        /// <summary>
        /// Updates the display control.
        /// </summary>
        /// <param name="court">The court.</param>
        public void UpdateDisplayControl(Court court)
        {
            foreach (CourtDisplayControl control in this.pnlControl.Controls)
            {
                if (control.CourtNumber == court.Number)
                {
                    control.SetData(court);
                    return;
                }
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the DisplayForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void DisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't close it, hide it insteand. Preventing it from disposing
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// Handles the Paint event of the PnlControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PnlControl_Paint(object sender, PaintEventArgs e)
        {
            if (this.brush != null)
            {
                this.brush.Dispose();
                this.brush = null;
            }

            var rect = new Rectangle(0, 0, this.Width, this.Height);
            this.brush = new LinearGradientBrush(rect, Color.DarkBlue, Color.DarkGreen, 45f);
            e.Graphics.FillRectangle(this.brush, rect);
            this.Invalidate();
        }

        /// <summary>
        /// Handles the Resize event of the PnlControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PnlControl_Resize(object sender, System.EventArgs e)
        {
            this.Invalidate();
        }
    }
}