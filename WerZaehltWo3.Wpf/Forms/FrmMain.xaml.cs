using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using System;
using System.Windows;
using WerZaehltWo3.Wpf.Forms;

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
            if (frmCourtCount.ShowDialog() == true)
            {
                throw new NotImplementedException("update settings after court count change");
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
    }
}
