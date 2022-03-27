using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Tests.Gui.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    public partial class FrmTsDatabaseTest : Form
    {
        private readonly TsDatabaseAdapter adapter = new TsDatabaseAdapter();

        public FrmTsDatabaseTest()
        {
            this.InitializeComponent();
        }

        private void TsDatabaseTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.TsFilepath = this.txtDatabaseFilepath.Text;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            this.adapter.Connect(this.txtDatabaseFilepath.Text);
        }

        private void BtnGetPlayers_Click(object sender, EventArgs e)
        {
            var players = this.adapter.GetPlayers();
            this.lvwPlayers.Items.Clear();
            foreach (var player in players)
            {
                var item = new ListViewItem(player);
                this.lvwPlayers.Items.Add(item);
            }            
        }

        private void TmrMatches_Tick(object sender, EventArgs e)
        {
            this.UpdateMatches();
        }

        private void UpdateMatches()
        {
            var bla = this.adapter.GetCurrentMatches();

            this.LvwCurrentMatches.Items.Clear();
            foreach (var match in bla)
            {
                var item = new ListViewItem(match.Court.ToString());
                item.SubItems.Add(match.PlanDate.ToString());
                item.SubItems.Add(match.Team1.ToStringShort());
                item.SubItems.Add(match.Team2.ToStringShort());
                item.SubItems.Add(match.Draw.Name);
                item.SubItems.Add(match.Roundnr.ToString());
                this.LvwCurrentMatches.Items.Add(item);
            }

            var blubb = this.adapter.GetPlannedMatches();
            this.LvwPlannedMatches.Items.Clear();
            foreach (var match in blubb)
            {
                var item = new ListViewItem(match.Court.ToString());
                item.SubItems.Add(match.PlanDate.ToString());
                item.SubItems.Add(match.Team1.ToStringShort());
                item.SubItems.Add(match.Team2.ToStringShort());
                item.SubItems.Add(match.Draw.Name);
                item.SubItems.Add(match.Roundnr.ToString());
                this.LvwPlannedMatches.Items.Add(item);
            }
        }

        private void BtnStartAutoUpdate_Click(object sender, EventArgs e)
        {
            this.TmrMatches.Start();
        }

        private void BtnStopAutoupdate_Click(object sender, EventArgs e)
        {
            this.TmrMatches.Stop();
        }

        private void BtnOneTimeUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateMatches();
        }
    }
}