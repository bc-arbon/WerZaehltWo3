using BCA.WerZaehltWo3.Shared;
using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Shared.TournamentTv;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmTtv : Form
    {
        public FrmTtv()
        {
            this.InitializeComponent();
        }

        private readonly TtvListener listener = new TtvListener(Application.StartupPath);

        public delegate void SetTsDataHandler(object sender, SetTsDataEventArgs setTsDatatEventArgs);

        public event SetTsDataHandler OnSetTsData;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            listener.Update += Listener_Update;
            listener.Start();
            this.BtnStart.Enabled = false;
            this.BtnStop.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            listener.Update -= this.Listener_Update;
            listener.Stop();
            this.BtnStart.Enabled = true;
            this.BtnStop.Enabled = false;
        }

        private void Listener_Update(object sender, TournamentTvUpdateEventArgs e)
        {
            var onCourtMatches = new List<ListViewItem>();
            var scheduledMatches = new List<ListViewItem>();
            var finishedMatches = new List<ListViewItem>();
            var countMatches = new List<ListViewItem>();
            var readyMatches = new List<ListViewItem>();

            foreach (var match in e.Tournament.MatchesOnCourt)
            {
                onCourtMatches.Add(this.CreateItem(match));
            }

            foreach (var match in e.Tournament.MatchesScheduled)
            {
                scheduledMatches.Add(this.CreateItem(match));
            }

            for (var i = 1; i <= 8; i++)
            {
                var countFound = false;
                foreach (var match in e.Tournament.MatchesScheduled)
                {
                    if (match.Court == i.ToString() && !countFound)
                    {
                        countMatches.Add(this.CreateItem(match));
                        countFound = true;
                    }
                    else if (match.Court == i.ToString() && countFound)
                    {
                        readyMatches.Add(this.CreateItem(match));
                        break;
                    }
                }
            }

            foreach (var match in e.Tournament.MatchesFinished)
            {
                finishedMatches.Add(this.CreateItem(match));
            }

            this.LvwOnCourt.Invoke((MethodInvoker)delegate 
            {            
                this.LvwOnCourt.Items.Clear();
                this.LvwScheduled.Items.Clear();
                this.LvwFinished.Items.Clear();
                this.LvwCounting.Items.Clear();
                this.LvwReady.Items.Clear();

                this.LvwOnCourt.Items.AddRange(onCourtMatches.ToArray());
                this.LvwScheduled.Items.AddRange(scheduledMatches.ToArray());
                this.LvwFinished.Items.AddRange(finishedMatches.ToArray());
                this.LvwCounting.Items.AddRange(countMatches.ToArray());
                this.LvwReady.Items.AddRange(readyMatches.ToArray());

                this.LblLastUpdate.Text = DateTime.Now.ToString();
            });
        }

        private void CmsApply_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var sourceObject = (ListView)((ContextMenuStrip)sender).SourceControl;
            if (sourceObject.Name == "LvwOnCourt")
            {
                if (this.LvwOnCourt.SelectedItems.Count > 0)
                {
                    var match = (DisplayMatch)this.LvwOnCourt.SelectedItems[0].Tag;
                    this.MnuApply.Text = "Übernehmen bei Spielen auf Feld " + match.Court;
                    this.MnuApply.Tag = new KeyValuePair<TsDataType, DisplayMatch>(TsDataType.Play, match);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (sourceObject.Name == "LvwCounting")
            {
                if (this.LvwCounting.SelectedItems.Count > 0)
                {
                    var match = (DisplayMatch)this.LvwCounting.SelectedItems[0].Tag;
                    this.MnuApply.Text = "Übernehmen bei Zählen auf Feld " + match.Court;
                    this.MnuApply.Tag = new KeyValuePair<TsDataType, DisplayMatch>(TsDataType.Counting, match);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (sourceObject.Name == "LvwReady")
            {
                if (this.LvwReady.SelectedItems.Count > 0)
                {
                    var match = (DisplayMatch)this.LvwReady.SelectedItems[0].Tag;
                    this.MnuApply.Text = "Übernehmen bei Bereit halten auf Feld " + match.Court;
                    this.MnuApply.Tag = new KeyValuePair<TsDataType, DisplayMatch>(TsDataType.Ready, match);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private ListViewItem CreateItem(DisplayMatch match)
        {
            return new ListViewItem(new string[] { match.Court, match.ScheduledTime.ToString(), match.EventName, match.Round, match.Team1, match.Team2 }) { Tag = match };
        }

        private void MnuApply_Click(object sender, EventArgs e)
        {
            var handler = this.OnSetTsData;
            if (handler != null)
            {
                var match = (KeyValuePair<TsDataType, DisplayMatch>)this.MnuApply.Tag;
                handler(this, new SetTsDataEventArgs { Type = match.Key, Court = Convert.ToInt32(match.Value.Court), Team1 = match.Value.Team1, Team2 = match.Value.Team2 });
            }
        }

        private void FrmTtv_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't close it, hide it insteand. Preventing it from disposing
            e.Cancel = true;
            this.Hide();
        }
    }
}