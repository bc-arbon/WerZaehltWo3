using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;

namespace BCA.WerZaehltWo3.Usercontrols
{
    public partial class CourtDisplayControl : UserControl
    {
        private readonly LinearGradientBrush brushLine;
        private readonly LinearGradientBrush brushReady;
        private readonly LinearGradientBrush brushCount;
        private readonly LinearGradientBrush brushPlay;
        private readonly Rectangle gradientRect;
        private readonly Rectangle lineRect;

        public CourtDisplayControl()
        {
            this.InitializeComponent();

            this.gradientRect = new Rectangle(0, 0, 211, 95);
            this.lineRect = new Rectangle(0, 47, 211, 1);
            this.brushLine = new LinearGradientBrush(this.lineRect, Color.Black, Color.White, 0f);
            this.brushReady = new LinearGradientBrush(this.gradientRect, Color.OrangeRed, Color.FromArgb(255, 181, 181), 45f);
            this.brushCount = new LinearGradientBrush(this.gradientRect, Color.Yellow, Color.FromArgb(255, 253, 149), 45f);
            this.brushPlay = new LinearGradientBrush(this.gradientRect, Color.Green, Color.FromArgb(192, 255, 192), 45f);
        }

        public int CourtNumber { get; private set; }

        public float FontSize
        {
            get
            {
                return this.lblPlay1.Font.Size;
            }

            set
            {
                this.lblPlay1.Font = new Font(this.lblPlay1.Font.Name, value, FontStyle.Bold);
                this.lblPlay2.Font = new Font(this.lblPlay2.Font.Name, value, FontStyle.Bold);
                this.lblReady1.Font = new Font(this.lblReady1.Font.Name, value, FontStyle.Bold);
                this.lblReady2.Font = new Font(this.lblReady2.Font.Name, value, FontStyle.Bold);
                this.lblCounting1.Font = new Font(this.lblCounting1.Font.Name, value, FontStyle.Bold);
                this.lblCounting2.Font = new Font(this.lblCounting2.Font.Name, value, FontStyle.Bold);
            }
        }

        public void SetData(Court court)
        {
            this.CourtNumber = court.Number;
            this.lblCourtNumber.Text = court.Number.ToString(CultureInfo.InvariantCulture);

            this.SetPlayer(this.lblReady1, court.PlayerReady1);
            this.SetPlayer(this.lblReady2, court.PlayerReady2);
            this.SetPlayer(this.lblCounting1, court.PlayerCount1);
            this.SetPlayer(this.lblCounting2, court.PlayerCount2);
            this.SetPlayer(this.lblPlay1, court.PlayerPlay1);
            this.SetPlayer(this.lblPlay2, court.PlayerPlay2);
        }

        private void SetPlayer(Control label, string player)
        {
            if (player != null)
            {
                if (!string.IsNullOrEmpty(player) && player.Contains("/"))
                {
                    var split = player.Split('/');
                    if (split.Length > 1)
                    {
                        label.Text = split[0].Trim() + Environment.NewLine + split[1].Trim();
                    }
                }
                else
                {
                    label.Text = player;
                }
            }
        }

        private void PnlReady_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(this.brushReady, this.gradientRect);
            e.Graphics.FillRectangle(this.brushLine, 0, 47, 211, 1);
        }

        private void PnlCount_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(this.brushCount, this.gradientRect);
            e.Graphics.FillRectangle(this.brushLine, 0, 47, 211, 1);
        }

        private void PnlPlay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(this.brushPlay, this.gradientRect);
            e.Graphics.FillRectangle(this.brushLine, this.lineRect);
        }
    }
}