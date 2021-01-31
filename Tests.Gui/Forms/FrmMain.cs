using BCA.WerZaehltWo3.Shared.ObjectModel;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
        }

        private void BtnJsonTest_Click(object sender, EventArgs e)
        {
            var board = new Playerboard();
            var file = "config.json";

            File.WriteAllText(file, JsonConvert.SerializeObject(board, Formatting.Indented));
            //var board2 = JsonConvert.DeserializeObject<Playerboard>(File.ReadAllText(file));
        }

        private void BtnTsPlanningTest_Click(object sender, EventArgs e)
        {
            var bla = new TsPlanningTestForm();
            bla.ShowDialog();
        }

        private void btnTsTest_Click(object sender, EventArgs e)
        {
            var bla = new FrmTsDatabaseTest();
            bla.ShowDialog();
        }
    }
}