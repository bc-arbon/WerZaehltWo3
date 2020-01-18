﻿namespace BCA.WerZaehltWo3.Usercontrols
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

    public partial class CourtSettingsControl : UserControl
    {
        private readonly LimitedStack<string> backups;

        private readonly PlayerboardManager playerboardManager;

        private Court court = new Court();

        public CourtSettingsControl(PlayerboardManager manager)
        {
            this.InitializeComponent();
            this.playerboardManager = manager;
            this.backups = new LimitedStack<string>(100);
        }

        public delegate void ApplyHandler(object sender, CourtEventArgs courtEventArgs);

        public event ApplyHandler OnApplyRequested;

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