namespace BCA.WerZaehltWo3.Forms
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    using BCA.WerZaehltWo3.Logic;
    using BCA.WerZaehltWo3.Usercontrols;
    using BCA.WerZaehltWo3.ObjectModel;

    public partial class FrmDisplay : Form
    {
        private LinearGradientBrush brush;
        
        public FrmDisplay()
        {
            this.InitializeComponent();
        }

        public PlayerboardManager PlayerboardManager { get; set; }

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

        private void DisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't close it, hide it insteand. Preventing it from disposing
            e.Cancel = true;
            this.Hide();
        }

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

        private void PnlControl_Resize(object sender, System.EventArgs e)
        {
            this.Invalidate();
        }
    }
}