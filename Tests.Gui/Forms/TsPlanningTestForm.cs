﻿using BCA.WerZaehltWo3.Adapters;
using BCA.WerZaehltWo3.ObjectModel.TournamentSoftware;
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
            //adapter.Connect("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            //var bla = adapter.GetEvents();

            //foreach (var ev in bla)
            //{
            //    this.txtOutput.Text += ev.Id + " - " + ev.Name + Environment.NewLine;
            //}
        }

        private void btnGetPlanningIds_Click(object sender, EventArgs e)
        {
            var adapter = new TsDatabaseAdapter();
            adapter.SetupConnection("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
            var matches = adapter.GetMatches();
            //var evnts = adapter.GetEvents();

            //var entries = new List<Entry>();
            //foreach (var evnt in evnts)
            //{
            //    entries.AddRange(adapter.GetEntries(evnt.Id));
            //}

            //var matches = adapter.GetCurrentMatches(entries);

            //adapter.Close();
        }

        private void btnGetCurrentMatches_Click(object sender, EventArgs e)
        {
            var adapter = new TsDatabaseAdapter();
            adapter.SetupConnection("C:\\Users\\dani\\Documents\\Turniere\\Testturnier.TP");
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
