
namespace GUIDX.UserControls
{
    partial class ValidatorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_Input = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ValidatorInput = new System.Windows.Forms.TextBox();
            this.L_Output = new System.Windows.Forms.Label();
            this.GB_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Input
            // 
            this.GB_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Input.Controls.Add(this.label1);
            this.GB_Input.Controls.Add(this.TB_ValidatorInput);
            this.GB_Input.Location = new System.Drawing.Point(3, 3);
            this.GB_Input.Name = "GB_Input";
            this.GB_Input.Size = new System.Drawing.Size(308, 101);
            this.GB_Input.TabIndex = 5;
            this.GB_Input.TabStop = false;
            this.GB_Input.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Example: \r\n\r\nxxxxxxxx-xxxx-xxxx-xxxxxxxxxxxx";
            // 
            // TB_ValidatorInput
            // 
            this.TB_ValidatorInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_ValidatorInput.Location = new System.Drawing.Point(3, 16);
            this.TB_ValidatorInput.Name = "TB_ValidatorInput";
            this.TB_ValidatorInput.Size = new System.Drawing.Size(302, 20);
            this.TB_ValidatorInput.TabIndex = 0;
            this.TB_ValidatorInput.TextChanged += new System.EventHandler(this.TB_ValidatorInput_TextChanged);
            // 
            // L_Output
            // 
            this.L_Output.AutoSize = true;
            this.L_Output.Location = new System.Drawing.Point(16, 121);
            this.L_Output.Name = "L_Output";
            this.L_Output.Size = new System.Drawing.Size(76, 13);
            this.L_Output.TabIndex = 4;
            this.L_Output.Text = "Output: Invalid";
            // 
            // ValidatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GB_Input);
            this.Controls.Add(this.L_Output);
            this.Name = "ValidatorControl";
            this.Size = new System.Drawing.Size(314, 304);
            this.GB_Input.ResumeLayout(false);
            this.GB_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ValidatorInput;
        private System.Windows.Forms.Label L_Output;
    }
}
