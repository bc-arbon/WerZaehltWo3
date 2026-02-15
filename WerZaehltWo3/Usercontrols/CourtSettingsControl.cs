using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BCA.WerZaehltWo3.Shared;
using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Usercontrols
{
    public partial class CourtSettingsControl : UserControl
    {
        private readonly LimitedStack<string> backups;

        private Court court = new Court();

        private bool isInitializing = false;

        public CourtSettingsControl()
        {
            this.InitializeComponent();
            this.backups = new LimitedStack<string>(100);
        }

        public delegate void ApplyHandler(object sender, CourtEventArgs courtEventArgs);

        public event ApplyHandler OnApplyRequested;

        public int CourtNumber
        {
            get
            {
                return this.court.Number;
            }
        }

        public void SetTeams(TsDataType type, string team1, string team2)
        {
            switch (type)
            {
                case TsDataType.Play:
                    this.TxtPlay1.Text = team1;
                    this.TxtPlay2.Text = team2;
                    break;
                case TsDataType.Counting:
                    this.TxtCount1.Text = team1;
                    this.TxtCount2.Text = team2;
                    break;
                case TsDataType.Ready:
                    this.TxtReady1.Text = team1;
                    this.TxtReady2.Text = team2;
                    break;
            }
        }

        public void SetInitialData(Court courtData, List<string> playerlist)
        {
            // This is only called on application startup and court count change
            this.isInitializing = true;
            this.court = courtData;
            this.LblCourtNumber.Text = courtData.Number.ToString(CultureInfo.InvariantCulture);

            if (courtData.PlayerReady1 != null)
            {
                this.TxtReady1.Text = courtData.PlayerReady1;
            }

            if (courtData.PlayerReady2 != null)
            {
                this.TxtReady2.Text = courtData.PlayerReady2;
            }

            if (courtData.PlayerCount1 != null)
            {
                this.TxtCount1.Text = courtData.PlayerCount1;
            }

            if (courtData.PlayerCount2 != null)
            {
                this.TxtCount2.Text = courtData.PlayerCount2;
            }

            if (courtData.PlayerPlay1 != null)
            {
                this.TxtPlay1.Text = courtData.PlayerPlay1;
            }

            if (courtData.PlayerPlay2 != null)
            {
                this.TxtPlay2.Text = courtData.PlayerPlay2;
            }

            var players = playerlist.Select(player => player).ToArray();
            this.SetAutocompletionData(players);

            this.SaveState();

            this.isInitializing = false;
        }

        public void SetAutocompletionData(string[] players)
        {
            this.TxtReady1.AutoCompleteCustomSource.Clear();
            this.TxtReady2.AutoCompleteCustomSource.Clear();
            this.TxtCount1.AutoCompleteCustomSource.Clear();
            this.TxtCount2.AutoCompleteCustomSource.Clear();
            this.TxtPlay1.AutoCompleteCustomSource.Clear();
            this.TxtPlay2.AutoCompleteCustomSource.Clear();
            this.TxtReady1.AutoCompleteCustomSource.AddRange(players);
            this.TxtReady2.AutoCompleteCustomSource.AddRange(players);
            this.TxtCount1.AutoCompleteCustomSource.AddRange(players);
            this.TxtCount2.AutoCompleteCustomSource.AddRange(players);
            this.TxtPlay1.AutoCompleteCustomSource.AddRange(players);
            this.TxtPlay2.AutoCompleteCustomSource.AddRange(players);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.SaveState();

            this.TxtReady1.Text = null;
            this.TxtReady2.Text = null;
            this.TxtCount1.Text = null;
            this.TxtCount2.Text = null;
            this.TxtPlay1.Text = null;
            this.TxtPlay2.Text = null;
        }

        public void Apply()
        {
            this.SaveState();

            this.court.PlayerReady1 = this.TxtReady1.Text;
            this.court.PlayerReady2 = this.TxtReady2.Text;
            this.court.PlayerCount1 = this.TxtCount1.Text;
            this.court.PlayerCount2 = this.TxtCount2.Text;
            this.court.PlayerPlay1 = this.TxtPlay1.Text;
            this.court.PlayerPlay2 = this.TxtPlay2.Text;

            var handler = this.OnApplyRequested;
            if (handler != null)
            {
                handler(this, new CourtEventArgs(this.court));
            }

            // Reset dirty state of textboxes
            this.TxtReady1.BackColor = Color.FromArgb(255, 181, 181);
            this.TxtReady2.BackColor = Color.FromArgb(255, 181, 181);
            this.TxtCount1.BackColor = Color.FromArgb(255, 253, 149);
            this.TxtCount2.BackColor = Color.FromArgb(255, 253, 149);
            this.TxtPlay1.BackColor = Color.FromArgb(192, 255, 192);
            this.TxtPlay2.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            var tempCourt = (Court)JsonHelper.Load(this.backups.Pop(), typeof(Court));
            this.TxtReady1.Text = tempCourt.PlayerReady1;
            this.TxtReady2.Text = tempCourt.PlayerReady2;
            this.TxtCount1.Text = tempCourt.PlayerCount1;
            this.TxtCount2.Text = tempCourt.PlayerCount2;
            this.TxtPlay1.Text = tempCourt.PlayerPlay1;
            this.TxtPlay2.Text = tempCourt.PlayerPlay2;

            this.BtnUndo.Enabled = this.backups.Count > 0;
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            this.SaveState();
            this.TxtPlay1.Text = this.TxtCount1.Text;
            this.TxtPlay2.Text = this.TxtCount2.Text;
            this.TxtCount1.Text = this.TxtReady1.Text;
            this.TxtCount2.Text = this.TxtReady2.Text;
            this.TxtReady1.Text = null;
            this.TxtReady2.Text = null;
        }

        private void Txtboxes_TextChanged(object sender, EventArgs e)
        {
            if (this.isInitializing)
            {
                return;
            }

            // Set textbox as dirty
            ((TextBox)sender).BackColor = Color.Aqua;
        }

        private void SaveState()
        {
            var tempCourt = new Court();
            tempCourt.PlayerReady1 = this.TxtReady1.Text;
            tempCourt.PlayerReady2 = this.TxtReady2.Text;
            tempCourt.PlayerCount1 = this.TxtCount1.Text;
            tempCourt.PlayerCount2 = this.TxtCount2.Text;
            tempCourt.PlayerPlay1 = this.TxtPlay1.Text;
            tempCourt.PlayerPlay2 = this.TxtPlay2.Text;
            this.backups.Push(JsonHelper.Save(tempCourt));
            this.BtnUndo.Enabled = this.backups.Count > 0;
        }
    }
}