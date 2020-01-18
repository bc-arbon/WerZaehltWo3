namespace BCA.WerZaehltWo3.Forms
{
    using BCA.WerZaehltWo3.Eventing;
    using BCA.WerZaehltWo3.Logic;
    using BCA.WerZaehltWo3.Usercontrols;
    using System;
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        /// <summary>
        /// The playerboard manager
        /// </summary>
        private readonly PlayerboardManager playerboardManager = new PlayerboardManager();

        /// <summary>
        /// The display form
        /// </summary>
        private readonly FrmDisplay displayForm = new FrmDisplay();

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.playerboardManager.Load();

            this.displayForm.PlayerboardManager = this.playerboardManager;
            this.displayForm.Show();

            this.InitializeSettingControls();
            this.displayForm.InitializeDisplayControls();
        }

        private void mnuFileShowDisplay_Click(object sender, EventArgs e)
        {
            this.displayForm.Show();
        }

        private void mnuFileEditPlayers_Click(object sender, EventArgs e)
        {
            var playerForm = new FrmPlayer(this.playerboardManager.Playerboard);
            if (playerForm.ShowDialog() == DialogResult.OK)
            {
                // Re-Read playerlist and populate comboboxes
            }
        }

        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFileSetCourtCount_Click(object sender, EventArgs e)
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

        private void mnuHelpInfo_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.playerboardManager.Save();
        }




        /// <summary>
        /// Updates the setting controls.
        /// </summary>
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

        /// <summary>
        /// Handles the OnApplyRequested event of the SettingsControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="courtEventArgs">The <see cref="CourtEventArgs"/> instance containing the event data.</param>
        private void SettingsControl_OnApplyRequested(object sender, CourtEventArgs courtEventArgs)
        {
            this.displayForm.UpdateDisplayControl(courtEventArgs.Court);
        }
    }
}