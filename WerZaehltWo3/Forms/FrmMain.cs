using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Usercontrols;
using System;
using System.Windows.Forms;
using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmMain : Form
    {
        private AppSettings appSettings = new AppSettings();
        private Playerboard playerboard = new Playerboard();
        private readonly FrmDisplay displayForm = new FrmDisplay();        
        private FrmTtv frmTtv;

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

            this.frmTtv = new FrmTtv();
            this.frmTtv.OnSetTsData += FrmTtv_OnSetTsData;
            this.frmTtv.Show();
        }

        private void FrmTtv_OnSetTsData(object sender, SetTsDataEventArgs setTsDataEventArgs)
        {
            foreach (var control in this.pnlSettingsControls.Controls)
            {
                var settingsControl = (CourtSettingsControl)control;
                if (settingsControl.CourtNumber == setTsDataEventArgs.Court)
                {
                    settingsControl.SetTeams(setTsDataEventArgs.Type, setTsDataEventArgs.Team1, setTsDataEventArgs.Team2);
                    break;
                }
            }
        }

        private void MnuFileShowDisplay_Click(object sender, EventArgs e)
        {
            this.displayForm.Show();
        }

        private void MnuFileTsMonitor_Click(object sender, EventArgs e)
        {
            this.frmTtv.Show();
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
                this.appSettings.CourtCount = courtCountForm.CourtCount;
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
                settingsControl.OnApplyRequested += this.SettingsControl_OnApplyRequested;
                this.pnlSettingsControls.Controls.Add(settingsControl);
            }
        }

        private void SettingsControl_OnApplyRequested(object sender, CourtEventArgs courtEventArgs)
        {
            this.displayForm.UpdateDisplayControl(courtEventArgs.Court);
            PlayerboardLogic.Save(this.playerboard);
        }

        private void FrmTsMonitor_OnSetTsData(object sender, SetTsDataEventArgs setTsDataEventArgs)
        {
            foreach (var control in this.pnlSettingsControls.Controls)
            {
                var settingsControl = (CourtSettingsControl)control;
                if (settingsControl.CourtNumber == setTsDataEventArgs.Court)
                {
                    settingsControl.SetTeams(setTsDataEventArgs.Type, setTsDataEventArgs.Team1, setTsDataEventArgs.Team2);
                    break;
                }
            }
        }

        private void MnuApplyAll_Click(object sender, EventArgs e)
        {
            foreach (var control in this.pnlSettingsControls.Controls)
            {
                var settingsControl = (CourtSettingsControl)control;
                settingsControl.Apply();
            }
        }
    }
}