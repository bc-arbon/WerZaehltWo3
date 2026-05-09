using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Shared.TpNetwork;
using BCA.WerZaehltWo3.Shared.TpNetwork.Data;
using BCA.WerZaehltWo3.Shared.TpNetwork.Logic;

namespace TpNetworkGui
{
    public partial class FrmMain : Form
    {
        private VisualXmlResponse currentResponse;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = await TpNetworkAdapter.Login(this.TxtIp.Text, this.TxtIp.Text, this.TxtPassword.Text);
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            var result = await TpNetworkAdapter.GetTournamentInfo(this.TxtIp.Text, this.TxtIp.Text, this.TxtPassword.Text);
            this.currentResponse = result;

            foreach (var draw in result.Draws)
            {
                this.CbxDraws.Items.Add(draw);
            }
        }

        private void CbxDraws_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CbxDraws.SelectedItem == null)
            {
                return;
            }

            var draw = this.CbxDraws.SelectedItem as Draw;
            this.listView1.Items.Clear();
            var matches = this.currentResponse.Matches.Where(m => m.DrawID == draw.ID).ToList().Where(m => m.IsMatch == false).ToList().Where(m => m.EntryID != 0);
            foreach (var match in matches)
            {
                var player = TournamentInfoHelper.GetPlayerByEntryId(this.currentResponse, match.EntryID);
                var club = TournamentInfoHelper.GetClubById(this.currentResponse, player[0].ClubID);
                var bhz = TournamentInfoHelper.GetBHZFromPlanningId(this.currentResponse, match.DrawID, match.PlanningID);

                var item = new ListViewItem(match.DrawID.ToString());
                item.SubItems.Add(match.PlanningID.ToString());
                item.SubItems.Add(player[0].Firstname + " " + player[0].Lastname);
                item.SubItems.Add(club.Name);
                item.SubItems.Add(match.MatchesPlayed.ToString());
                item.SubItems.Add(match.MatchesWon.ToString());
                item.SubItems.Add(bhz.ToString());
                item.SubItems.Add(match.SetsFor + " - " + match.SetsAgainst);
                item.SubItems.Add(match.GamesFor + " - " + match.GamesAgainst);
                this.listView1.Items.Add(item);
            }
        }
    }
}
