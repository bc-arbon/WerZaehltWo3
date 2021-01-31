using BCA.WerZaehltWo3.Shared.Logic;
using System;
using System.Windows;
using WerZaehltWo3.Wpf.Forms;

namespace WerZaehltWo3.Wpf
{
    public partial class FrmMain : Window
    {
        private readonly SettingsManager settingsManager = new SettingsManager();

        private readonly PlayerboardManager playerboardManager = new PlayerboardManager();

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
            var frmPlayers = new FrmPlayers(this.playerboardManager.Playerboard);
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
            this.playerboardManager.Load();
            this.settingsManager.Load();
            //this.Size = this.settingsManager.AppSettings.WindowSize;

            //this.displayForm.PlayerboardManager = this.playerboardManager;
            this.displayForm.Show();

            //this.InitializeSettingControls();
            //this.displayForm.InitializeDisplayControls();
            //this.displayForm.SetFontSize(this.playerboardManager.Playerboard.Settings.FontSize);
        }
    }
}
