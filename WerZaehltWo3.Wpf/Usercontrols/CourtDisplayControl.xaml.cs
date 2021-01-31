using BCA.WerZaehltWo3.Shared.ObjectModel;
using System;
using System.Windows.Controls;

namespace WerZaehltWo3.Wpf.Usercontrols
{
    public partial class CourtDisplayControl : UserControl
    {
        public CourtDisplayControl()
        {
            this.InitializeComponent();
        }

        public int CourtNumber { get; private set; }

        public void SetData(Court court)
        {
            this.CourtNumber = court.Number;
            this.LblCourtNumber.Text = court.Number.ToString();

            this.SetPlayer(this.LblReady1, court.PlayerReady1);
            this.SetPlayer(this.LblReady2, court.PlayerReady2);
            this.SetPlayer(this.LblCount1, court.PlayerCount1);
            this.SetPlayer(this.LblCount2, court.PlayerCount2);
            this.SetPlayer(this.LblPlay1, court.PlayerPlay1);
            this.SetPlayer(this.LblPlay2, court.PlayerPlay2);
        }

        private void SetPlayer(TextBlock label, string player)
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
    }
}
