
namespace GUIDX.UserControls
{
    partial class GeneratorControl
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
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Output = new System.Windows.Forms.GroupBox();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.P_Main = new System.Windows.Forms.Panel();
            this.CB_Uppercase = new System.Windows.Forms.CheckBox();
            this.CB_Suffix = new System.Windows.Forms.CheckBox();
            this.CB_Prefix = new System.Windows.Forms.CheckBox();
            this.TB_Suffix = new System.Windows.Forms.TextBox();
            this.TB_Prefix = new System.Windows.Forms.TextBox();
            this.L_Format = new System.Windows.Forms.Label();
            this.L_Amount = new System.Windows.Forms.Label();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.CB_Format = new System.Windows.Forms.ComboBox();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.TLP_Main.SuspendLayout();
            this.GB_Output.SuspendLayout();
            this.P_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Main
            // 
            this.TLP_Main.ColumnCount = 1;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Controls.Add(this.GB_Output, 0, 1);
            this.TLP_Main.Controls.Add(this.P_Main, 0, 0);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 2;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Size = new System.Drawing.Size(423, 418);
            this.TLP_Main.TabIndex = 8;
            // 
            // GB_Output
            // 
            this.GB_Output.Controls.Add(this.TB_Output);
            this.GB_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Output.Location = new System.Drawing.Point(3, 124);
            this.GB_Output.Name = "GB_Output";
            this.GB_Output.Size = new System.Drawing.Size(417, 291);
            this.GB_Output.TabIndex = 9;
            this.GB_Output.TabStop = false;
            this.GB_Output.Text = "Output";
            // 
            // TB_Output
            // 
            this.TB_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Output.Location = new System.Drawing.Point(3, 16);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.ReadOnly = true;
            this.TB_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Output.Size = new System.Drawing.Size(411, 272);
            this.TB_Output.TabIndex = 1;
            // 
            // P_Main
            // 
            this.P_Main.Controls.Add(this.CB_Uppercase);
            this.P_Main.Controls.Add(this.CB_Suffix);
            this.P_Main.Controls.Add(this.CB_Prefix);
            this.P_Main.Controls.Add(this.TB_Suffix);
            this.P_Main.Controls.Add(this.TB_Prefix);
            this.P_Main.Controls.Add(this.L_Format);
            this.P_Main.Controls.Add(this.L_Amount);
            this.P_Main.Controls.Add(this.BTN_Generate);
            this.P_Main.Controls.Add(this.BTN_Copy);
            this.P_Main.Controls.Add(this.CB_Format);
            this.P_Main.Controls.Add(this.NUD_Amount);
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(3, 3);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(417, 115);
            this.P_Main.TabIndex = 10;
            // 
            // CB_Uppercase
            // 
            this.CB_Uppercase.AutoSize = true;
            this.CB_Uppercase.Location = new System.Drawing.Point(12, 68);
            this.CB_Uppercase.Name = "CB_Uppercase";
            this.CB_Uppercase.Size = new System.Drawing.Size(78, 17);
            this.CB_Uppercase.TabIndex = 21;
            this.CB_Uppercase.Text = "Uppercase";
            this.CB_Uppercase.UseVisualStyleBackColor = true;
            this.CB_Uppercase.CheckedChanged += new System.EventHandler(this.CB_Checkboxes_CheckedChanged);
            // 
            // CB_Suffix
            // 
            this.CB_Suffix.AutoSize = true;
            this.CB_Suffix.Location = new System.Drawing.Point(96, 89);
            this.CB_Suffix.Name = "CB_Suffix";
            this.CB_Suffix.Size = new System.Drawing.Size(55, 17);
            this.CB_Suffix.TabIndex = 20;
            this.CB_Suffix.Text = "Suffix:";
            this.CB_Suffix.UseVisualStyleBackColor = true;
            this.CB_Suffix.CheckedChanged += new System.EventHandler(this.CB_Checkboxes_CheckedChanged);
            // 
            // CB_Prefix
            // 
            this.CB_Prefix.AutoSize = true;
            this.CB_Prefix.Location = new System.Drawing.Point(96, 68);
            this.CB_Prefix.Name = "CB_Prefix";
            this.CB_Prefix.Size = new System.Drawing.Size(55, 17);
            this.CB_Prefix.TabIndex = 19;
            this.CB_Prefix.Text = "Prefix:";
            this.CB_Prefix.UseVisualStyleBackColor = true;
            this.CB_Prefix.CheckedChanged += new System.EventHandler(this.CB_Checkboxes_CheckedChanged);
            // 
            // TB_Suffix
            // 
            this.TB_Suffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Suffix.Location = new System.Drawing.Point(157, 89);
            this.TB_Suffix.Name = "TB_Suffix";
            this.TB_Suffix.Size = new System.Drawing.Size(247, 20);
            this.TB_Suffix.TabIndex = 17;
            this.TB_Suffix.Text = "\")]";
            this.TB_Suffix.TextChanged += new System.EventHandler(this.TB_Prefix_TextChanged);
            // 
            // TB_Prefix
            // 
            this.TB_Prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Prefix.Location = new System.Drawing.Point(157, 66);
            this.TB_Prefix.Name = "TB_Prefix";
            this.TB_Prefix.Size = new System.Drawing.Size(247, 20);
            this.TB_Prefix.TabIndex = 15;
            this.TB_Prefix.Text = "[Guid(\"";
            this.TB_Prefix.TextChanged += new System.EventHandler(this.TB_Prefix_TextChanged);
            // 
            // L_Format
            // 
            this.L_Format.AutoSize = true;
            this.L_Format.Location = new System.Drawing.Point(93, 42);
            this.L_Format.Name = "L_Format";
            this.L_Format.Size = new System.Drawing.Size(42, 13);
            this.L_Format.TabIndex = 12;
            this.L_Format.Text = "Format:";
            // 
            // L_Amount
            // 
            this.L_Amount.AutoSize = true;
            this.L_Amount.Location = new System.Drawing.Point(93, 15);
            this.L_Amount.Name = "L_Amount";
            this.L_Amount.Size = new System.Drawing.Size(46, 13);
            this.L_Amount.TabIndex = 11;
            this.L_Amount.Text = "Amount:";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Location = new System.Drawing.Point(12, 10);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Generate.TabIndex = 0;
            this.BTN_Generate.Text = "Generate";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(12, 39);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(75, 23);
            this.BTN_Copy.TabIndex = 3;
            this.BTN_Copy.Text = "Copy";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // CB_Format
            // 
            this.CB_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Format.FormattingEnabled = true;
            this.CB_Format.Location = new System.Drawing.Point(157, 39);
            this.CB_Format.Name = "CB_Format";
            this.CB_Format.Size = new System.Drawing.Size(247, 21);
            this.CB_Format.TabIndex = 2;
            this.CB_Format.SelectedIndexChanged += new System.EventHandler(this.CB_Format_SelectedIndexChanged);
            // 
            // NUD_Amount
            // 
            this.NUD_Amount.Location = new System.Drawing.Point(157, 13);
            this.NUD_Amount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.Name = "NUD_Amount";
            this.NUD_Amount.Size = new System.Drawing.Size(66, 20);
            this.NUD_Amount.TabIndex = 4;
            this.NUD_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.ValueChanged += new System.EventHandler(this.NUD_Amount_ValueChanged);
            // 
            // GeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP_Main);
            this.Name = "GeneratorControl";
            this.Size = new System.Drawing.Size(423, 418);
            this.Load += new System.EventHandler(this.GeneratorControl_Load);
            this.TLP_Main.ResumeLayout(false);
            this.GB_Output.ResumeLayout(false);
            this.GB_Output.PerformLayout();
            this.P_Main.ResumeLayout(false);
            this.P_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.GroupBox GB_Output;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Panel P_Main;
        private System.Windows.Forms.CheckBox CB_Uppercase;
        private System.Windows.Forms.CheckBox CB_Suffix;
        private System.Windows.Forms.CheckBox CB_Prefix;
        private System.Windows.Forms.TextBox TB_Suffix;
        private System.Windows.Forms.TextBox TB_Prefix;
        private System.Windows.Forms.Label L_Format;
        private System.Windows.Forms.Label L_Amount;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.ComboBox CB_Format;
        private System.Windows.Forms.NumericUpDown NUD_Amount;
    }
}
