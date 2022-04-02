using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;
using System;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Usercontrols
{
    public partial class TsCourtControl : UserControl
    {        
        private readonly Hub hub = Hub.Default;

        public TsCourtControl()
        {
            InitializeComponent();
        }

        public int CourtNumber { get; private set; }

        public void SetData(int courtNumber)
        {
            this.CourtNumber = courtNumber;
            this.lblCourtNumber.Text = courtNumber.ToString();
        }

        public void SetPlayerReady(string player1, string player2)
        {
            this.txtReady1.Text = player1;            
            this.txtReady2.Text = player2;
        }

        public void SetPlayerCount(string player1, string player2)
        {
            this.txtCount1.Text = player1;
            this.txtCount2.Text = player2;
        }

        public void SetPlayerPlay(string player1, string player2)
        {
            this.txtPlay1.Text = player1;
            this.txtPlay2.Text = player2;
        }

        private void BtnApplyReady_Click(object sender, EventArgs e)
        {
            this.hub.Publish<TsCourtUpdateEvent>(new TsCourtUpdateEvent(this.CourtNumber, DataType.Ready, this.txtReady1.Text, this.txtReady2.Text));
        }

        private void BtnApplyCount_Click(object sender, EventArgs e)
        {
            this.hub.Publish<TsCourtUpdateEvent>(new TsCourtUpdateEvent(this.CourtNumber, DataType.Count, this.txtCount1.Text, this.txtCount2.Text));
        }

        private void BtnApplyPlay_Click(object sender, EventArgs e)
        {
            this.hub.Publish<TsCourtUpdateEvent>(new TsCourtUpdateEvent(this.CourtNumber, DataType.Play, this.txtPlay1.Text, this.txtPlay2.Text));
        }
    }
}
