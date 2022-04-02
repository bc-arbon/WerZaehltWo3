using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;
using System;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Usercontrols
{
    public partial class TsCourtControl : UserControl
    {
        private int courtNumber;
        private readonly Hub hub = Hub.Default;

        public TsCourtControl()
        {
            InitializeComponent();
        }

        public void SetData(int courtNumber)
        {
            this.courtNumber = courtNumber;
            this.lblCourtNumber.Text = courtNumber.ToString();
        }

        private void BtnApplyReady_Click(object sender, EventArgs e)
        {
            this.hub.Publish<TsCourtUpdateEvent>(new TsCourtUpdateEvent(this.courtNumber, DataType.Ready, this.txtReady1.Text, this.txtReady2.Text));
        }

        private void BtnApplyCount_Click(object sender, EventArgs e)
        {

        }

        private void BtnApplyPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
