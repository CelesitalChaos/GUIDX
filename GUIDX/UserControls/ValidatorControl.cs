#region Namespaces

using System;
using System.Windows.Forms;

using GUIDX.Utilities;

#endregion

namespace GUIDX.UserControls
{
    /// <summary>
    ///     The <see cref="ValidatorControl" /> user control.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ValidatorControl : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ValidatorControl" /> class.
        /// </summary>
        public ValidatorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Handles the TextChanged event of the TB_ValidatorInput control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void TB_ValidatorInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_ValidatorInput.Text))
            {
                L_Output.Text = @"Output: Invalid";
            }

            if (GUIDValidator.IsGUIDParse(TB_ValidatorInput.Text))
            {
                L_Output.Text = @"Output: Valid";
            }
            else
            {
                L_Output.Text = @"Output: Invalid";
            }
        }
    }
}