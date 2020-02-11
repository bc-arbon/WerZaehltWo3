using BCA.WerZaehltWo3.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    public partial class TsPlanningTestForm : Form
    {
        public TsPlanningTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adapter = new TsDatabaseAdapter();
            adapter.Connect("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            var bla = adapter.GetEvents();

            foreach (var ev in bla)
            {
                this.txtOutput.Text += ev.Id + " - " + ev.Name + Environment.NewLine;
            }
        }

        private void btnGetPlanningIds_Click(object sender, EventArgs e)
        {
            var adapter = new TsDatabaseAdapter();
            adapter.Connect("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            var bla = adapter.GetEntries(Convert.ToInt32(this.txtEventId.Text));

        }
    }
}
