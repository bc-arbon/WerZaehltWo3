using BCA.WerZaehltWo3.Shared.TournamentTv;

namespace Tests.TournamentTv
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
        }

        private readonly TtvListener listener = new TtvListener(Path.GetDirectoryName(Environment.ProcessPath));

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

        private ListViewItem CreateItem(DisplayMatch match)
        {
            return new ListViewItem(new string[] { match.Court, match.ScheduledTime.ToString(), match.EventName, match.Round, match.Team1, match.Team2 }) { Tag = match };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listener.ServiceStarted += (sender, e) => Console.WriteLine("Listener started");
            //listener.ServiceError += (sender, e) => Console.WriteLine(e.Item2.Message);
            //listener.ServiceStopped += (sender, e) => Console.WriteLine("Listener stopped");
        }
    }
}