
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
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.TSSL_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.TC_Main = new System.Windows.Forms.TabControl();
            this.TP_Generator = new System.Windows.Forms.TabPage();
            this.TP_Validator = new System.Windows.Forms.TabPage();
            this.MS_Menu = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratorControl = new GUIDX.UserControls.GeneratorControl();
            this.SS_Main.SuspendLayout();
            this.TC_Main.SuspendLayout();
            this.TP_Generator.SuspendLayout();
            this.MS_Menu.SuspendLayout();
            this.SuspendLayout();
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
            this.TP_Generator.Controls.Add(this.GeneratorControl);
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
            this.TP_Validator.Location = new System.Drawing.Point(4, 22);
            this.TP_Validator.Name = "TP_Validator";
            this.TP_Validator.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Validator.Size = new System.Drawing.Size(376, 328);
            this.TP_Validator.TabIndex = 1;
            this.TP_Validator.Text = "Validator";
            this.TP_Validator.UseVisualStyleBackColor = true;
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
            this.TSMI_Exit.Size = new System.Drawing.Size(93, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // GeneratorControl
            // 
            this.GeneratorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratorControl.Location = new System.Drawing.Point(3, 3);
            this.GeneratorControl.Name = "GeneratorControl";
            this.GeneratorControl.Size = new System.Drawing.Size(370, 322);
            this.GeneratorControl.TabIndex = 0;
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
            this.SS_Main.ResumeLayout(false);
            this.SS_Main.PerformLayout();
            this.TC_Main.ResumeLayout(false);
            this.TP_Generator.ResumeLayout(false);
            this.MS_Menu.ResumeLayout(false);
            this.MS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip SS_Main;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Version;
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage TP_Generator;
        private System.Windows.Forms.TabPage TP_Validator;
        private System.Windows.Forms.MenuStrip MS_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private UserControls.GeneratorControl GeneratorControl;
    }
}

