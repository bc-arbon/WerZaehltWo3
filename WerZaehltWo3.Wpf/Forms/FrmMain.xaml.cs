using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using System;
using System.Windows;
using WerZaehltWo3.Wpf.Forms;
using WerZaehltWo3.Wpf.Usercontrols;

namespace WerZaehltWo3.Wpf
{
    public partial class FrmMain : Window
    {
        private AppSettings appSettings = new AppSettings();
        private Playerboard playerboard = new Playerboard();
        private readonly FrmDisplay displayForm = new FrmDisplay();

        public FrmMain()
        {
            this.InitializeComponent();            
        }

        private void MnuShowDisplay_Click(object sender, RoutedEventArgs e)
        {
            this.displayForm.Show();
        }

        private void MnuEditPlayers_Click(object sender, RoutedEventArgs e)
        {
            var frmPlayers = new FrmPlayers(this.playerboard);
            frmPlayers.ShowDialog();
        }

        private void MnuSetCourtCount_Click(object sender, RoutedEventArgs e)
        {
            var frmCourtCount = new FrmCourtCount();
            frmCourtCount.SetData(this.playerboard.Courts.Count);
            if (frmCourtCount.ShowDialog() == true)
            {
                PlayerboardLogic.SetCourtCount(this.playerboard, frmCourtCount.CourtCount);
                this.displayForm.InitializeDisplayControls();
                this.InitializeSettingControls();

                PlayerboardLogic.Save(this.playerboard);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.playerboard = PlayerboardLogic.Load();
            this.appSettings = AppSettingsLogic.Load();
            //this.Size = this.settingsManager.AppSettings.WindowSize;

            //this.displayForm.PlayerboardManager = this.playerboardManager;
            this.displayForm.Show();

            //this.InitializeSettingControls();
            //this.displayForm.InitializeDisplayControls();
            //this.displayForm.SetFontSize(this.playerboardManager.Playerboard.Settings.FontSize);
        }

        private void InitializeSettingControls()
        {
            this.PnlSettingsControls.Children.Clear();
            foreach (var court in this.playerboard.Courts)
            {
                var settingsControl = new CourtSettingsControl();
                //settingsControl.SetData(court, this.playerboard.Players);
                //settingsControl.OnApplyRequested += this.SettingsControl_OnApplyRequested;
                this.PnlSettingsControls.Children.Add(settingsControl);
            }
        }
    }
}
