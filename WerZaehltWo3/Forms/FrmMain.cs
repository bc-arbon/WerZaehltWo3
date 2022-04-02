using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Usercontrols;
using System;
using System.Windows.Forms;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;
using BCA.WerZaehltWo3.Shared.Eventing;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmMain : Form
    {
        private AppSettings appSettings = new AppSettings();
        private Playerboard playerboard = new Playerboard();
        private readonly FrmDisplay displayForm = new FrmDisplay();
        private readonly FrmTsData tsdataForm = new FrmTsData();
        private readonly Hub hub = Hub.Default;

        public FrmMain()
        {
            this.InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.playerboard = PlayerboardLogic.Load();
            this.appSettings = AppSettingsLogic.Load();
            this.Size = this.appSettings.WindowSize;

            this.displayForm.Playerboard = this.playerboard;
            this.displayForm.Show();

            this.InitializeSettingControls();
            this.displayForm.InitializeDisplayControls();
            this.displayForm.SetFontSize(this.playerboard.Settings.FontSize);

            this.tsdataForm.Playerboard = this.playerboard;
            this.tsdataForm.Show();

            this.hub.Subscribe<TsCourtUpdateEvent>(x => this.ApplyTsData(x.CourtNumber, x.DataType, x.Player1, x.Player2));
        }

        private void MnuFileShowDisplay_Click(object sender, EventArgs e)
        {
            this.displayForm.Show();
        }

        private void MnuFileEditPlayers_Click(object sender, EventArgs e)
        {
            var playerForm = new FrmPlayer(this.playerboard);
            if (playerForm.ShowDialog() == DialogResult.OK)
            {
                var players = this.playerboard.Players.ToArray();
                foreach (var settingsControl in this.pnlSettingsControls.Controls)
                {
                    if (settingsControl is CourtSettingsControl control)
                    {
                        control.SetAutocompletionData(players);
                    }
                }

                PlayerboardLogic.Save(this.playerboard);
            }
        }

        private void MnuFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuFileSetCourtCount_Click(object sender, EventArgs e)
        {
            var courtCountForm = new FrmCourtCount();
            courtCountForm.SetData(this.playerboard.Courts.Count);
            if (courtCountForm.ShowDialog() == DialogResult.OK)
            {
                PlayerboardLogic.SetCourtCount(this.playerboard, courtCountForm.CourtCount);
                this.displayForm.InitializeDisplayControls();
                this.InitializeSettingControls();

                PlayerboardLogic.Save(this.playerboard);
            }
        }

        private void MnuHelpInfo_Click(object sender, EventArgs e)
        {
            new FrmInfo().ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayerboardLogic.Save(this.playerboard);

            this.appSettings.WindowSize = this.Size;
            AppSettingsLogic.Save(this.appSettings);
        }

        private void InitializeSettingControls()
        {
            this.pnlSettingsControls.Controls.Clear();
            foreach (var court in this.playerboard.Courts)
            {
                var settingsControl = new CourtSettingsControl();
                settingsControl.SetData(court, this.playerboard.Players);
                this.pnlSettingsControls.Controls.Add(settingsControl);
            }
        }

        private void ApplyTsData(int courtNumber, DataType dataType, string player1, string player2)
        {
            foreach (CourtSettingsControl control in this.pnlSettingsControls.Controls)
            {
                if (control.CourtNumber == courtNumber)
                {
                    switch (dataType)
                    {
                        case DataType.Ready:
                            control.SetPlayersReady(player1, player2);
                            break;
                        case DataType.Count:
                            control.SetPlayersCount(player1, player2);
                            break;
                        case DataType.Play:
                            control.SetPlayersPlay(player1, player2);
                            break;
                    }
                    
                    return;
                }
            }
        }
    }
}