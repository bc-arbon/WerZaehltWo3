namespace BCA.WerZaehltWo3.Usercontrols
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Globalization;
    using System.Windows.Forms;

    using BCA.WerZaehltWo3.ObjectModel;

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

        public void SetData(Court court)
        {
            this.CourtNumber = court.Number;
            this.lblCourtNumber.Text = court.Number.ToString(CultureInfo.InvariantCulture);

            this.SetPlayer(this.lblReady1, court.PlayersReady.Player1);
            this.SetPlayer(this.lblReady2, court.PlayersReady.Player2);
            this.SetPlayer(this.lblCounting1, court.PlayersCount.Player1);
            this.SetPlayer(this.lblCounting2, court.PlayersCount.Player2);
            this.SetPlayer(this.lblPlay1, court.PlayersPlay.Player1);
            this.SetPlayer(this.lblPlay2, court.PlayersPlay.Player2);
        }

        private void SetPlayer(Control label, Player player)
        {
            if (player != null)
            {
                label.Text = player.Name;
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