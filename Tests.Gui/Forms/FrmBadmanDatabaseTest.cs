namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    using BCA.WerZaehltWo3.Adapters;
    using BCA.WerZaehltWo3.Tests.Gui.Properties;
    using System;
    using System.Windows.Forms;

    public partial class FrmBadmanDatabaseTest : Form
    {
        private readonly BadmanDatabaseAdapter adapter = new BadmanDatabaseAdapter();

        public FrmBadmanDatabaseTest()
        {
            this.InitializeComponent();
        }

        private void BadmanDatabaseTest_Load(object sender, EventArgs e)
        {
            this.txtDatabaseFilepath.Text = Settings.Default.DatabaseFilepath;
        }

        private void BadmanDatabaseTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.DatabaseFilepath = this.txtDatabaseFilepath.Text;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            this.adapter.Connect(this.txtDatabaseFilepath.Text);
            var tournaments = this.adapter.GetTournaments();
            this.txtTournaments.AutoCompleteCustomSource.Clear();
            foreach (var tournament in tournaments)
            {
                this.txtTournaments.AutoCompleteCustomSource.Add(tournament);
            }
        }

        private void BtnGetPlayers_Click(object sender, EventArgs e)
        {
            this.lvwPlayers.Items.Clear();
            var players = this.adapter.GetPlayers(this.txtTournaments.Text);
            foreach (var player in players)
            {
                var item = new ListViewItem(player.Id);
                item.SubItems.Add(player.Name);
                item.SubItems.Add(player.Club);
                item.SubItems.Add(player.Category);
                this.lvwPlayers.Items.Add(item);
            }
        }
    }
}