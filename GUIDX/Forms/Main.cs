#region Namespaces

using System;
using System.Windows.Forms;

#endregion

namespace GUIDX.Forms
{
    public partial class Main : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Main" /> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();

            TSSL_Version.Text = @"Version: " + Application.ProductVersion;
        }

        /// <summary>
        ///     Handles the Load event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     Handles the Click event of the TSMI_Exit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}