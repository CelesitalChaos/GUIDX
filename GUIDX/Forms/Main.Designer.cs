
namespace GUIDX.Forms
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.CB_Format = new System.Windows.Forms.ComboBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.P_Main = new System.Windows.Forms.Panel();
            this.CB_Suffix = new System.Windows.Forms.CheckBox();
            this.CB_Prefix = new System.Windows.Forms.CheckBox();
            this.TB_Suffix = new System.Windows.Forms.TextBox();
            this.TB_Prefix = new System.Windows.Forms.TextBox();
            this.L_Format = new System.Windows.Forms.Label();
            this.L_Amount = new System.Windows.Forms.Label();
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.TSSL_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.TC_Main = new System.Windows.Forms.TabControl();
            this.TP_Generator = new System.Windows.Forms.TabPage();
            this.TP_Validator = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ValidatorInput = new System.Windows.Forms.TextBox();
            this.L_Output = new System.Windows.Forms.Label();
            this.MS_Menu = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            this.TLP_Main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.P_Main.SuspendLayout();
            this.SS_Main.SuspendLayout();
            this.TC_Main.SuspendLayout();
            this.TP_Generator.SuspendLayout();
            this.TP_Validator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.MS_Menu.SuspendLayout();
            this.SuspendLayout();
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
            // TB_Output
            // 
            this.TB_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Output.Location = new System.Drawing.Point(3, 16);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.ReadOnly = true;
            this.TB_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Output.Size = new System.Drawing.Size(358, 176);
            this.TB_Output.TabIndex = 1;
            // 
            // CB_Format
            // 
            this.CB_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Format.FormattingEnabled = true;
            this.CB_Format.Location = new System.Drawing.Point(157, 39);
            this.CB_Format.Name = "CB_Format";
            this.CB_Format.Size = new System.Drawing.Size(194, 21);
            this.CB_Format.TabIndex = 2;
            this.CB_Format.SelectedIndexChanged += new System.EventHandler(this.CB_Mode_SelectedIndexChanged);
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
            // TLP_Main
            // 
            this.TLP_Main.ColumnCount = 1;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Controls.Add(this.groupBox1, 0, 1);
            this.TLP_Main.Controls.Add(this.P_Main, 0, 0);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(3, 3);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 2;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Size = new System.Drawing.Size(370, 322);
            this.TLP_Main.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Output);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 195);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // P_Main
            // 
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
            this.P_Main.Size = new System.Drawing.Size(364, 115);
            this.P_Main.TabIndex = 10;
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
            this.CB_Suffix.CheckedChanged += new System.EventHandler(this.CB_Prefix_CheckedChanged);
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
            this.CB_Prefix.CheckedChanged += new System.EventHandler(this.CB_Prefix_CheckedChanged);
            // 
            // TB_Suffix
            // 
            this.TB_Suffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Suffix.Location = new System.Drawing.Point(157, 89);
            this.TB_Suffix.Name = "TB_Suffix";
            this.TB_Suffix.Size = new System.Drawing.Size(194, 20);
            this.TB_Suffix.TabIndex = 17;
            this.TB_Suffix.Text = "\")]";
            // 
            // TB_Prefix
            // 
            this.TB_Prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Prefix.Location = new System.Drawing.Point(157, 66);
            this.TB_Prefix.Name = "TB_Prefix";
            this.TB_Prefix.Size = new System.Drawing.Size(194, 20);
            this.TB_Prefix.TabIndex = 15;
            this.TB_Prefix.Text = "[Guid(\"";
            // 
            // L_Format
            // 
            this.L_Format.AutoSize = true;
            this.L_Format.Location = new System.Drawing.Point(93, 42);
            this.L_Format.Name = "L_Format";
            this.L_Format.Size = new System.Drawing.Size(37, 13);
            this.L_Format.TabIndex = 12;
            this.L_Format.Text = "Mode:";
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
            // SS_Main
            // 
            this.SS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Version});
            this.SS_Main.Location = new System.Drawing.Point(0, 378);
            this.SS_Main.Name = "SS_Main";
            this.SS_Main.Size = new System.Drawing.Size(384, 22);
            this.SS_Main.SizingGrip = false;
            this.SS_Main.TabIndex = 8;
            this.SS_Main.Text = "statusStrip1";
            // 
            // TSSL_Version
            // 
            this.TSSL_Version.Name = "TSSL_Version";
            this.TSSL_Version.Size = new System.Drawing.Size(369, 17);
            this.TSSL_Version.Spring = true;
            this.TSSL_Version.Text = "Version: #.#.#.#";
            // 
            // TC_Main
            // 
            this.TC_Main.Controls.Add(this.TP_Generator);
            this.TC_Main.Controls.Add(this.TP_Validator);
            this.TC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Main.Location = new System.Drawing.Point(0, 24);
            this.TC_Main.Name = "TC_Main";
            this.TC_Main.SelectedIndex = 0;
            this.TC_Main.Size = new System.Drawing.Size(384, 354);
            this.TC_Main.TabIndex = 11;
            // 
            // TP_Generator
            // 
            this.TP_Generator.Controls.Add(this.TLP_Main);
            this.TP_Generator.Location = new System.Drawing.Point(4, 22);
            this.TP_Generator.Name = "TP_Generator";
            this.TP_Generator.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Generator.Size = new System.Drawing.Size(376, 328);
            this.TP_Generator.TabIndex = 0;
            this.TP_Generator.Text = "Generator";
            this.TP_Generator.UseVisualStyleBackColor = true;
            // 
            // TP_Validator
            // 
            this.TP_Validator.Controls.Add(this.groupBox4);
            this.TP_Validator.Controls.Add(this.L_Output);
            this.TP_Validator.Location = new System.Drawing.Point(4, 22);
            this.TP_Validator.Name = "TP_Validator";
            this.TP_Validator.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Validator.Size = new System.Drawing.Size(376, 343);
            this.TP_Validator.TabIndex = 1;
            this.TP_Validator.Text = "Validator";
            this.TP_Validator.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TB_ValidatorInput);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 101);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input";
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
            this.TB_ValidatorInput.Size = new System.Drawing.Size(355, 20);
            this.TB_ValidatorInput.TabIndex = 0;
            this.TB_ValidatorInput.TextChanged += new System.EventHandler(this.TB_ValidatorInput_TextChanged);
            // 
            // L_Output
            // 
            this.L_Output.AutoSize = true;
            this.L_Output.Location = new System.Drawing.Point(19, 124);
            this.L_Output.Name = "L_Output";
            this.L_Output.Size = new System.Drawing.Size(76, 13);
            this.L_Output.TabIndex = 2;
            this.L_Output.Text = "Output: Invalid";
            // 
            // MS_Menu
            // 
            this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File});
            this.MS_Menu.Location = new System.Drawing.Point(0, 0);
            this.MS_Menu.Name = "MS_Menu";
            this.MS_Menu.Size = new System.Drawing.Size(384, 24);
            this.MS_Menu.TabIndex = 12;
            this.MS_Menu.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Exit});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(37, 20);
            this.TSMI_File.Text = "File";
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 400);
            this.Controls.Add(this.TC_Main);
            this.Controls.Add(this.SS_Main);
            this.Controls.Add(this.MS_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Menu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GUID X";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            this.TLP_Main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.P_Main.ResumeLayout(false);
            this.P_Main.PerformLayout();
            this.SS_Main.ResumeLayout(false);
            this.SS_Main.PerformLayout();
            this.TC_Main.ResumeLayout(false);
            this.TP_Generator.ResumeLayout(false);
            this.TP_Validator.ResumeLayout(false);
            this.TP_Validator.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.MS_Menu.ResumeLayout(false);
            this.MS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.ComboBox CB_Format;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.NumericUpDown NUD_Amount;
        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.StatusStrip SS_Main;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Version;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage TP_Generator;
        private System.Windows.Forms.TabPage TP_Validator;
        private System.Windows.Forms.TextBox TB_ValidatorInput;
        private System.Windows.Forms.Label L_Output;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_Main;
        private System.Windows.Forms.Label L_Amount;
        private System.Windows.Forms.Label L_Format;
        private System.Windows.Forms.TextBox TB_Suffix;
        private System.Windows.Forms.TextBox TB_Prefix;
        private System.Windows.Forms.CheckBox CB_Suffix;
        private System.Windows.Forms.CheckBox CB_Prefix;
        private System.Windows.Forms.MenuStrip MS_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
    }
}

