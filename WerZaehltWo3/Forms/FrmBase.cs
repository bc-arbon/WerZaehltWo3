namespace BCA.WerZaehltWo3.Forms
{
    using System.Windows.Forms;

    /// <summary>
    /// BaseForm class
    /// </summary>
    public partial class FrmBase : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmBase"/> class.
        /// </summary>
        public FrmBase()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the KeyDown event of the BaseForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}