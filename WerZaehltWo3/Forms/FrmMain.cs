namespace BCA.WerZaehltWo3.Forms
{
    using BCA.WerZaehltWo3.Eventing;
    using BCA.WerZaehltWo3.Logic;
    using BCA.WerZaehltWo3.Usercontrols;
    using System;
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        private readonly PlayerboardManager playerboardManager = new PlayerboardManager();

        private readonly FrmDisplay displayForm = new FrmDisplay();

        public FrmMain()
        {
            this.InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.playerboardManager.Load();

            this.displayForm.PlayerboardManager = this.playerboardManager;
            this.displayForm.Show();

            this.InitializeSettingControls();
            this.displayForm.InitializeDisplayControls();
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
                // TODO
                // Re-Read playerlist and populate comboboxes
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
            }
        }

        private void MnuHelpInfo_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.playerboardManager.Save();
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