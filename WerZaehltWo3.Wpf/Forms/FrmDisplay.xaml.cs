using BCA.WerZaehltWo3.Shared.ObjectModel;
using System.Windows;
using WerZaehltWo3.Wpf.Usercontrols;

namespace WerZaehltWo3.Wpf.Forms
{
    public partial class FrmDisplay : Window
    {
        public FrmDisplay()
        {
            this.InitializeComponent();
        }

        public Playerboard Playerboard { get; set; }

        public void InitializeDisplayControls()
        {
            this.PnlControls.Children.Clear();
            foreach (var court in this.Playerboard.Courts)
            {
                var settingsControl = new CourtDisplayControl();
                settingsControl.SetData(court);
                this.PnlControls.Children.Add(settingsControl);
            }
        }

        public void UpdateDisplayControl(Court court)
        {
            foreach (CourtDisplayControl control in this.PnlControls.Children)
            {
                if (control.CourtNumber == court.Number)
                {
                    control.SetData(court);
                    return;
                }
            }
        }
        
        public void SetFontSize(float fontSize)
        {
            foreach (CourtDisplayControl control in this.PnlControls.Children)
            {
                control.FontSize = fontSize;
            }
        }
    }
}
