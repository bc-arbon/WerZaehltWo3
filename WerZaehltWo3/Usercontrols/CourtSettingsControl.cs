namespace BCA.WerZaehltWo3.Usercontrols
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    using BCA.WerZaehltWo3.ObjectModel;
    using BCA.WerZaehltWo3.Logic;
    using BCA.WerZaehltWo3.Eventing;
    using BCA.WerZaehltWo3.Common;

    /// <summary>
    /// CourtSettingsControl class
    /// </summary>
    public partial class CourtSettingsControl : UserControl
    {
        /// <summary>
        /// The backup court
        /// </summary>
        private readonly LimitedStack<string> backups;

        /// <summary>
        /// The playerboard manager
        /// </summary>
        private readonly PlayerboardManager playerboardManager;

        /// <summary>
        /// The court
        /// </summary>
        private Court court = new Court();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourtSettingsControl" /> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public CourtSettingsControl(PlayerboardManager manager)
        {
            this.InitializeComponent();
            this.playerboardManager = manager;
            this.backups = new LimitedStack<string>(100);
        }

        /// <summary>
        /// The ApplyHandler delegate
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="courtEventArgs">The <see cref="CourtEventArgs"/> instance containing the event data.</param>
        public delegate void ApplyHandler(object sender, CourtEventArgs courtEventArgs);

        /// <summary>
        /// Occurs when [on apply requested].
        /// </summary>
        public event ApplyHandler OnApplyRequested;

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="courtData">The court.</param>
        /// <param name="playerlist">The playerlist.</param>
        public void SetData(Court courtData, List<Player> playerlist)
        {
            this.court = courtData;
            this.lblCourtNumber.Text = courtData.Number.ToString(CultureInfo.InvariantCulture);

            if (courtData.PlayersReady.Player1 != null)
            {
                this.txtReady1.Text = courtData.PlayersReady.Player1.Name;
            }

            if (courtData.PlayersReady.Player1 != null)
            {
                this.txtReady2.Text = courtData.PlayersReady.Player2.Name;
            }

            if (courtData.PlayersCount.Player1 != null)
            {
                this.txtCount1.Text = courtData.PlayersCount.Player1.Name;
            }

            if (courtData.PlayersCount.Player2 != null)
            {
                this.txtCount2.Text = courtData.PlayersCount.Player2.Name;
            }

            if (courtData.PlayersPlay.Player1 != null)
            {
                this.txtPlay1.Text = courtData.PlayersPlay.Player1.Name;
            }

            if (courtData.PlayersPlay.Player2 != null)
            {
                this.txtPlay2.Text = courtData.PlayersPlay.Player2.Name;
            }

            var players = playerlist.Select(player => player.Name).ToArray();

            this.txtReady1.AutoCompleteCustomSource.Clear();
            this.txtReady2.AutoCompleteCustomSource.Clear();
            this.txtCount1.AutoCompleteCustomSource.Clear();
            this.txtCount2.AutoCompleteCustomSource.Clear();
            this.txtPlay1.AutoCompleteCustomSource.Clear();
            this.txtPlay2.AutoCompleteCustomSource.Clear();
            this.txtReady1.AutoCompleteCustomSource.AddRange(players);
            this.txtReady2.AutoCompleteCustomSource.AddRange(players);
            this.txtCount1.AutoCompleteCustomSource.AddRange(players);
            this.txtCount2.AutoCompleteCustomSource.AddRange(players);
            this.txtPlay1.AutoCompleteCustomSource.AddRange(players);
            this.txtPlay2.AutoCompleteCustomSource.AddRange(players);
        }

        /// <summary>
        /// Handles the Click event of the BtnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.SaveState();

            this.txtReady1.Text = null;
            this.txtReady2.Text = null;
            this.txtCount1.Text = null;
            this.txtCount2.Text = null;
            this.txtPlay1.Text = null;
            this.txtPlay2.Text = null;
        }

        /// <summary>
        /// Handles the Click event of the BtnApply control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BtnApply_Click(object sender, EventArgs e)
        {
            this.SaveState();

            this.court.PlayersReady.Player1 = this.playerboardManager.GetPlayer(this.txtReady1.Text);
            this.court.PlayersReady.Player2 = this.playerboardManager.GetPlayer(this.txtReady2.Text);
            this.court.PlayersCount.Player1 = this.playerboardManager.GetPlayer(this.txtCount1.Text);
            this.court.PlayersCount.Player2 = this.playerboardManager.GetPlayer(this.txtCount2.Text);
            this.court.PlayersPlay.Player1 = this.playerboardManager.GetPlayer(this.txtPlay1.Text);
            this.court.PlayersPlay.Player2 = this.playerboardManager.GetPlayer(this.txtPlay2.Text);

            var handler = this.OnApplyRequested;
            if (handler != null)
            {
                handler(this, new CourtEventArgs(this.court));
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnUndo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            this.court.LoadXml(this.backups.Pop());
            this.txtReady1.Text = this.court.PlayersReady.Player1.Name;
            this.txtReady2.Text = this.court.PlayersReady.Player2.Name;
            this.txtCount1.Text = this.court.PlayersCount.Player1.Name;
            this.txtCount2.Text = this.court.PlayersCount.Player2.Name;
            this.txtPlay1.Text = this.court.PlayersPlay.Player1.Name;
            this.txtPlay2.Text = this.court.PlayersPlay.Player2.Name;

            this.btnUndo.Enabled = this.backups.Count > 0;
        }

        /// <summary>
        /// Handles the Click event of the BtnMove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void BtnMove_Click(object sender, EventArgs e)
        {
            this.SaveState();

            this.txtPlay1.Text = this.txtCount1.Text;
            this.txtPlay2.Text = this.txtCount2.Text;
            this.txtCount1.Text = this.txtReady1.Text;
            this.txtCount2.Text = this.txtReady2.Text;
            this.txtReady1.Text = null;
            this.txtReady2.Text = null;
        }

        /// <summary>
        /// Saves the state.
        /// </summary>
        private void SaveState()
        {
            var tempCourt = this.court.Clone();
            tempCourt.PlayersReady.Player1 = new Player(this.txtReady1.Text);
            tempCourt.PlayersReady.Player2 = new Player(this.txtReady2.Text);
            tempCourt.PlayersCount.Player1 = new Player(this.txtCount1.Text);
            tempCourt.PlayersCount.Player2 = new Player(this.txtCount2.Text);
            tempCourt.PlayersPlay.Player1 = new Player(this.txtPlay1.Text);
            tempCourt.PlayersPlay.Player2 = new Player(this.txtPlay1.Text);
            this.backups.Push(tempCourt.Save());
            this.btnUndo.Enabled = true;
        }
    }
}