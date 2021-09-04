#region Namespaces

using System;
using System.Windows.Forms;

using GUIDX.Enums;
using GUIDX.Utilities;

#endregion

namespace GUIDX.UserControls
{
    /// <summary>
    ///     The <see cref="GeneratorControl" /> user control.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class GeneratorControl : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GeneratorControl" /> class.
        /// </summary>
        public GeneratorControl()
        {
            InitializeComponent();
            CB_Format.DataSource = Enum.GetValues(typeof(GUIDFormat));
        }

        /// <summary>
        ///     Handles the Click event of the BTN_Generate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            GUIDFormat format;
            Enum.TryParse(CB_Format.SelectedValue.ToString(), out format);

            GUIDGenerationOptions options = new GUIDGenerationOptions();
            options.Format = format;
            options.Prefix = CB_Prefix.Checked;
            options.PrefixText = TB_Prefix.Text;
            options.Suffix = CB_Suffix.Checked;
            options.SuffixText = TB_Suffix.Text;
            options.UpperCase = CB_Uppercase.Checked;

            var result = GUIDGenerator.Generate(options, Convert.ToInt32(NUD_Amount.Value));

            TB_Output.Text = result;
        }

        /// <summary>
        ///     Handles the Click event of the BTN_Copy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_Output.Text, TextDataFormat.Text);
        }

        /// <summary>
        ///     Handles the ValueChanged event of the NUD_Amount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void NUD_Amount_ValueChanged(object sender, EventArgs e)
        {
            BTN_Generate.PerformClick();
        }

        /// <summary>
        ///     Handles the SelectedIndexChanged event of the CB_Mode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CB_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_Generate.PerformClick();
        }

        /// <summary>
        ///     Handles the CheckedChanged event of the CB_Checkboxes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CB_Checkboxes_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Generate.PerformClick();
        }

        /// <summary>
        ///     Handles the TextChanged event of the TB_Prefix control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void TB_Prefix_TextChanged(object sender, EventArgs e)
        {
            BTN_Generate.PerformClick();
        }

        /// <summary>
        ///     Handles the Load event of the GeneratorControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void GeneratorControl_Load(object sender, EventArgs e)
        {
            BTN_Generate.PerformClick();
        }
    }
}