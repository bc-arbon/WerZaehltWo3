namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    using BCA.WerZaehltWo3.ObjectModel;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
        }

        private void btnJsonTest_Click(object sender, EventArgs e)
        {
            var board = new Playerboard();
            var file = "config.json";

            File.WriteAllText(file, JsonConvert.SerializeObject(board, Formatting.Indented));
            var board2 = JsonConvert.DeserializeObject<Playerboard>(File.ReadAllText(file));
        }

        private void btnTsPlanningTest_Click(object sender, EventArgs e)
        {
            var bla = new TsPlanningTestForm();
            bla.ShowDialog();
        }
    }
}