using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Shared.TpNetwork;

namespace TpNetworkGui
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = await TpNetworkAdapter.Login(this.TxtIp.Text, this.TxtIp.Text, this.TxtPassword.Text);
            this.TxtResponse.Text = result;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            var result = await TpNetworkAdapter.GetTournamentInfo(this.TxtIp.Text, this.TxtIp.Text, this.TxtPassword.Text, this.TxtUnicode.Text);
            this.TxtResponse.Text = result;
            var response = VisualXmlResponse.Parse(result);
        }
    }
}
