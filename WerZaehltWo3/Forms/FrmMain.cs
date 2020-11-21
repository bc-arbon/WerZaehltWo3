using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Usercontrols;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmMain : Form
    {
        private readonly SettingsManager settingsManager = new SettingsManager();

        private readonly PlayerboardManager playerboardManager = new PlayerboardManager();

        private readonly FrmDisplay displayForm = new FrmDisplay();

        public FrmMain()
        {
            this.InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.playerboardManager.Load();
            this.settingsManager.Load();
            this.Size = this.settingsManager.AppSettings.WindowSize;

            this.displayForm.PlayerboardManager = this.playerboardManager;           
            this.displayForm.Show();

            this.InitializeSettingControls();
            this.displayForm.InitializeDisplayControls();
            this.displayForm.SetFontSize(this.playerboardManager.Playerboard.Settings.FontSize);
        }

        private void MnuFileShowDisplay_Click(object sender, EventArgs e)
        {
            this.displayForm.Show();
        }

        private void MnuFileEditPlayers_Click(object sender, EventArgs e)
        {
            var playerForm = new FrmPlayer(this.playerboardManager.Playerboard);
            if (playerForm.ShowDialog() == DialogResult.OK)
            {
                var players = this.playerboardManager.GetPlayers().Select(player => player.Name).ToArray(); ;
                foreach (var settingsControl in this.pnlSettingsControls.Controls)
                {
                    if (settingsControl is CourtSettingsControl control)
                    {
                        control.SetAutocompletionData(players);
                    }
                }

                this.playerboardManager.Save();
            }
        }

        private void MnuFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuFileSetCourtCount_Click(object sender, EventArgs e)
        {
            var courtCountForm = new FrmCourtCount();
            courtCountForm.SetData(this.playerboardManager.Playerboard.Courts.Count);
            if (courtCountForm.ShowDialog() == DialogResult.OK)
            {
                this.playerboardManager.SetCourtCount(courtCountForm.CourtCount);
                this.displayForm.InitializeDisplayControls();
                this.InitializeSettingControls();

                this.playerboardManager.Save();
            }
        }

        private void MnuHelpInfo_Click(object sender, EventArgs e)
        {
            new FrmInfo().ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.playerboardManager.Save();

            this.settingsManager.AppSettings.WindowSize = this.Size;
            this.settingsManager.Save();
        }

        private void InitializeSettingControls()
        {
            this.pnlSettingsControls.Controls.Clear();
            foreach (var court in this.playerboardManager.Playerboard.Courts)
            {
                var settingsControl = new CourtSettingsControl(this.playerboardManager);
                settingsControl.SetData(court, this.playerboardManager.GetPlayers());
                settingsControl.OnApplyRequested += this.SettingsControl_OnApplyRequested;
                this.pnlSettingsControls.Controls.Add(settingsControl);
            }
        }

        private void SettingsControl_OnApplyRequested(object sender, CourtEventArgs courtEventArgs)
        {
            this.displayForm.UpdateDisplayControl(courtEventArgs.Court);
        }
    }
}