﻿namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    using BCA.WerZaehltWo3.Adapters;
    using BCA.WerZaehltWo3.Tests.Gui.Properties;
    using System;
    using System.Windows.Forms;

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
                var item = new ListViewItem(player.Id);
                item.SubItems.Add(player.Name);
                item.SubItems.Add(player.Club);
                item.SubItems.Add(player.Category);
                this.lvwPlayers.Items.Add(item);
            }
        }
    }
}