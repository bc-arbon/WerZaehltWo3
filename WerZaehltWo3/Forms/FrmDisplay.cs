using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using BCA.WerZaehltWo3.Usercontrols;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;
using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Shared.Logic;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmDisplay : Form
    {
        private readonly Hub hub = Hub.Default;
        private LinearGradientBrush brush;
        
        public FrmDisplay()
        {
            this.InitializeComponent();
        }

        public Playerboard Playerboard { get; set; }

        public void InitializeDisplayControls()
        {
            this.hub.Subscribe<CourtEventArgs>(x => this.UpdateDisplayControl(x.Court));

            this.pnlControl.Controls.Clear();
            foreach (var court in this.Playerboard.Courts)
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
                    PlayerboardLogic.Save(this.Playerboard);
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

        public void SetFontSize(float fontSize)
        {            
            foreach (CourtDisplayControl control in this.pnlControl.Controls)
            {
                control.FontSize = fontSize;           
            }
        }
    }
}