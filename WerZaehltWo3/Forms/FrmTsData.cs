using BCA.WerZaehltWo3.Shared.ObjectModel;
using BCA.WerZaehltWo3.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmTsData : Form
    {
        public FrmTsData()
        {
            this.InitializeComponent();
        }

        public Playerboard Playerboard { get; set; }

        public void InitializeDisplayControls()
        {
            this.PnlControls.Controls.Clear();
            foreach (var court in this.Playerboard.Courts)
            {
                var settingsControl = new TsCourtControl();
                settingsControl.SetData(court.Number);
                this.PnlControls.Controls.Add(settingsControl);
            }
        }

        public void UpdateDisplayControl(Court court)
        {
            foreach (TsCourtControl control in this.PnlControls.Controls)
            {
                //if (control.CourtNumber == court.Number)
                //{
                //    control.SetData(court);
                //    return;
                //}
            }
        }

        private void FrmTsData_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't close it, hide it insteand. Preventing it from disposing
            e.Cancel = true;
            this.Hide();
        }
    }
}
