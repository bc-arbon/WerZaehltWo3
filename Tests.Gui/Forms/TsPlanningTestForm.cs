using BCA.WerZaehltWo3.Shared.Adapters;
using System;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    public partial class TsPlanningTestForm : Form
    {
        public TsPlanningTestForm()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //var adapter = new TsDatabaseAdapter();
            //adapter.Connect("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            //var bla = adapter.GetEvents();

            //foreach (var ev in bla)
            //{
            //    this.txtOutput.Text += ev.Id + " - " + ev.Name + Environment.NewLine;
            //}
        }

        private void BtnGetPlanningIds_Click(object sender, EventArgs e)
        {
            var adapter = new TsDatabaseAdapter();
            adapter.Connect("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            //var matches = adapter.GetMatches();
            //var evnts = adapter.GetEvents();

            //var entries = new List<Entry>();
            //foreach (var evnt in evnts)
            //{
            //    entries.AddRange(adapter.GetEntries(evnt.Id));
            //}

            //var matches = adapter.GetCurrentMatches(entries);

            //adapter.Close();
        }

        private void BtnGetCurrentMatches_Click(object sender, EventArgs e)
        {
            var adapter = new TsDatabaseAdapter();
            adapter.Connect("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            var matches = adapter.GetCurrentMatches();

            for (var i = 1; i <= 8; i++)
            {
                this.txtOutput.Text += i + ": ";
                var match = matches.Find(x => x.Court == i);
                if (match != null)
                {
                    this.txtOutput.Text += match.Team1.ToStringShort() + " vs. " + match.Team2.ToStringShort();
                }

                this.txtOutput.Text += Environment.NewLine;
            }
        }
    }
}
