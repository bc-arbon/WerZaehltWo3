using BCA.WerZaehltWo3.Shared.TournamentTv;
using System.Security.Policy;

namespace Tests.TournamentTv
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
        }

        private TtvListener listener = new TtvListener(Path.GetDirectoryName(Environment.ProcessPath));

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

        private void Listener_Update(object? sender, TournamentTvUpdateEventArgs e)
        {
            var onCourtMatches = new List<ListViewItem>();
            var scheduledMatches = new List<ListViewItem>();
            var finishedMatches = new List<ListViewItem>();
            var countMatches = new List<ListViewItem>();
            var readyMatches = new List<ListViewItem>();

            foreach (var match in e.Tournament.MatchesOnCourt)
            {
                var team1 = match.FirstName1 + " " + match.LastName1;
                if (match.PlayerId2 != null)
                {
                    team1 += match.FirstName2 + " " + match.LastName2;
                }

                var team2 = match.FirstName3 + " " + match.LastName3;
                if (match.PlayerId3 != null)
                {
                    team2 += match.FirstName4 + " " + match.LastName4;
                }

                onCourtMatches.Add(new ListViewItem(new string[] { match.ScheduledTime.ToString(), match.EventName, match.Round, team1, team2, match.Court }));
            }

            foreach (var match in e.Tournament.MatchesScheduled)
            {
                var team1 = match.FirstName1 + " " + match.LastName1;
                if (!string.IsNullOrEmpty(match.PlayerId2))
                {
                    team1 += " / " + match.FirstName2 + " " + match.LastName2;
                }

                var team2 = match.FirstName3 + " " + match.LastName3;
                if (!string.IsNullOrEmpty(match.PlayerId4))
                {
                    team2 += " / " + match.FirstName4 + " " + match.LastName4;
                }

                scheduledMatches.Add(new ListViewItem(new string[] { match.ScheduledTime.ToString(), match.EventName, match.Round, team1, team2, match.Court }));
            }

            for (var i = 1; i <= 8; i++)
            {
                var countFound = false;
                foreach (var match in e.Tournament.MatchesScheduled)
                {
                    var team1 = match.FirstName1 + " " + match.LastName1;
                    if (!string.IsNullOrEmpty(match.PlayerId2))
                    {
                        team1 += " / " + match.FirstName2 + " " + match.LastName2;
                    }

                    var team2 = match.FirstName3 + " " + match.LastName3;
                    if (!string.IsNullOrEmpty(match.PlayerId4))
                    {
                        team2 += " / " + match.FirstName4 + " " + match.LastName4;
                    }

                    if (match.Court == i.ToString() && !countFound)
                    {
                        countMatches.Add(new ListViewItem(new string[] { match.ScheduledTime.ToString(), match.EventName, match.Round, team1, team2, match.Court }));
                        countFound = true;
                    }
                    else if (match.Court == i.ToString() && countFound)
                    {
                        readyMatches.Add(new ListViewItem(new string[] { match.ScheduledTime.ToString(), match.EventName, match.Round, team1, team2, match.Court }));
                        break;
                    }
                }
            }

            foreach (var match in e.Tournament.MatchesFinished)
            {
                var team1 = match.FirstName1 + " " + match.LastName1;
                if (match.PlayerId2 != null)
                {
                    team1 += match.FirstName2 + " " + match.LastName2;
                }

                var team2 = match.FirstName3 + " " + match.LastName3;
                if (match.PlayerId3 != null)
                {
                    team2 += match.FirstName4 + " " + match.LastName4;
                }

                finishedMatches.Add(new ListViewItem(new string[] { match.ScheduledTime.ToString(), match.EventName, match.Round, team1, team2, match.Court }));
            }

            Invoke(() =>
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //listener.ServiceStarted += (sender, e) => Console.WriteLine("Listener started");
            //listener.ServiceError += (sender, e) => Console.WriteLine(e.Item2.Message);
            //listener.ServiceStopped += (sender, e) => Console.WriteLine("Listener stopped");
        }

    }
}
