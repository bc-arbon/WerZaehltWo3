using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WerZaehltWo3.Wpf.Forms
{
    public partial class FrmCourtCount : Window
    {
        public FrmCourtCount()
        {
            this.InitializeComponent();
        }

        public int CourtCount { get; private set; }

        public void SetData(int courtCount)
        {
            this.CourtCount = courtCount;
            this.SldCount.Value = courtCount;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.CourtCount = Convert.ToInt32(this.SldCount.Value);
        }
    }
}
