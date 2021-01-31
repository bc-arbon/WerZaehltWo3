using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Tests.Gui.Properties;
using System;
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

        private void TsDatabaseTest_Load(object sender, EventArgs e)
        {
            this.txtDatabaseFilepath.Text = Settings.Default.TsFilepath;
        }

        private void TsDatabaseTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.TsFilepath = this.txtDatabaseFilepath.Text;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //this.adapter.Connect(this.txtDatabaseFilepath.Text);
            //var tournaments = this.adapter.GetTournaments();
            //this.txtTournaments.AutoCompleteCustomSource.Clear();
            //foreach (var tournament in tournaments)
            //{
            //    this.txtTournaments.AutoCompleteCustomSource.Add(tournament);
            //}
        }

        private void BtnGetPlayers_Click(object sender, EventArgs e)
        {
            this.lvwPlayers.Items.Clear();
            var players = this.adapter.GetPlayers();
            foreach (var player in players)
            {
                var item = new ListViewItem(player);
                this.lvwPlayers.Items.Add(item);
            }
        }
    }
}