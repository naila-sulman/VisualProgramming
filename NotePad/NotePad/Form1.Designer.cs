namespace NotePad
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.findNextF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontWithColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontWithoutColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNotePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.cCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCtrlNToolStripMenuItem,
            this.openCtrlOToolStripMenuItem,
            this.saveCtrlToolStripMenuItem,
            this.toolStripMenuItem2,
            this.pageSetupToolStripMenuItem,
            this.printCtrlPToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            this.newCtrlNToolStripMenuItem.Image = global::NotePad.Properties.Resources.New_file_icon;
            this.newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            this.newCtrlNToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newCtrlNToolStripMenuItem.Text = "New     Ctrl+N";
            this.newCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newCtrlNToolStripMenuItem_Click);
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.Image = global::NotePad.Properties.Resources.open_file_icon;
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openCtrlOToolStripMenuItem.Text = "Open...  Ctrl+O";
            this.openCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openCtrlOToolStripMenuItem_Click);
            // 
            // saveCtrlToolStripMenuItem
            // 
            this.saveCtrlToolStripMenuItem.Image = global::NotePad.Properties.Resources.Save_icon;
            this.saveCtrlToolStripMenuItem.Name = "saveCtrlToolStripMenuItem";
            this.saveCtrlToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveCtrlToolStripMenuItem.Text = "Save    ";
            this.saveCtrlToolStripMenuItem.Click += new System.EventHandler(this.saveCtrlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::NotePad.Properties.Resources.Save_as_icon;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Save As...";
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Image = global::NotePad.Properties.Resources.Pages_icon;
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            // 
            // printCtrlPToolStripMenuItem
            // 
            this.printCtrlPToolStripMenuItem.Image = global::NotePad.Properties.Resources.printer_icon;
            this.printCtrlPToolStripMenuItem.Name = "printCtrlPToolStripMenuItem";
            this.printCtrlPToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.printCtrlPToolStripMenuItem.Text = "Print     Ctrl+P";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::NotePad.Properties.Resources.Windows_Close_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem,
            this.deleteDelToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findNextF3ToolStripMenuItem,
            this.replaceCtrlToolStripMenuItem,
            this.goToCtrlGToolStripMenuItem,
            this.selectAllCtrlAToolStripMenuItem,
            this.timeDateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::NotePad.Properties.Resources.Undo_icon;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo   ";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::NotePad.Properties.Resources.Actions_cut_icon;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cutToolStripMenuItem.Text = "Cut    ";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::NotePad.Properties.Resources.copy_icon__1_;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.copyToolStripMenuItem.Text = "Copy    ";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Image = global::NotePad.Properties.Resources.Paste_icon;
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste    ";
            this.pasteCtrlVToolStripMenuItem.Click += new System.EventHandler(this.pasteCtrlVToolStripMenuItem_Click);
            // 
            // deleteDelToolStripMenuItem
            // 
            this.deleteDelToolStripMenuItem.Image = global::NotePad.Properties.Resources.blue_cross_icon;
            this.deleteDelToolStripMenuItem.Name = "deleteDelToolStripMenuItem";
            this.deleteDelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteDelToolStripMenuItem.Text = "Delete    ";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(172, 6);
            // 
            // findNextF3ToolStripMenuItem
            // 
            this.findNextF3ToolStripMenuItem.Image = global::NotePad.Properties.Resources.search_file_icon;
            this.findNextF3ToolStripMenuItem.Name = "findNextF3ToolStripMenuItem";
            this.findNextF3ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.findNextF3ToolStripMenuItem.Text = "Find...     Ctrl+F";
            this.findNextF3ToolStripMenuItem.Click += new System.EventHandler(this.findNextF3ToolStripMenuItem_Click);
            // 
            // replaceCtrlToolStripMenuItem
            // 
            this.replaceCtrlToolStripMenuItem.Image = global::NotePad.Properties.Resources.text_replace_icon;
            this.replaceCtrlToolStripMenuItem.Name = "replaceCtrlToolStripMenuItem";
            this.replaceCtrlToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.replaceCtrlToolStripMenuItem.Text = "Replace   ";
            this.replaceCtrlToolStripMenuItem.Click += new System.EventHandler(this.replaceCtrlToolStripMenuItem_Click);
            // 
            // goToCtrlGToolStripMenuItem
            // 
            this.goToCtrlGToolStripMenuItem.Image = global::NotePad.Properties.Resources.Actions_go_next_icon;
            this.goToCtrlGToolStripMenuItem.Name = "goToCtrlGToolStripMenuItem";
            this.goToCtrlGToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.goToCtrlGToolStripMenuItem.Text = "GoTo....    Ctrl+G";
            // 
            // selectAllCtrlAToolStripMenuItem
            // 
            this.selectAllCtrlAToolStripMenuItem.Image = global::NotePad.Properties.Resources.Sign_Select_icon;
            this.selectAllCtrlAToolStripMenuItem.Name = "selectAllCtrlAToolStripMenuItem";
            this.selectAllCtrlAToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.selectAllCtrlAToolStripMenuItem.Text = "Select All..    Ctrl+A";
            // 
            // timeDateToolStripMenuItem
            // 
            this.timeDateToolStripMenuItem.Image = global::NotePad.Properties.Resources.Date_and_Time_icon;
            this.timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            this.timeDateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.timeDateToolStripMenuItem.Text = "Time/Date     ";
            this.timeDateToolStripMenuItem.Click += new System.EventHandler(this.timeDateToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontWithColorToolStripMenuItem,
            this.fontWithoutColorToolStripMenuItem});
            this.fontToolStripMenuItem.Image = global::NotePad.Properties.Resources.Fonts_icon;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fontToolStripMenuItem.Text = "Font...";
            // 
            // fontWithColorToolStripMenuItem
            // 
            this.fontWithColorToolStripMenuItem.Name = "fontWithColorToolStripMenuItem";
            this.fontWithColorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.fontWithColorToolStripMenuItem.Text = "Font With Color";
            this.fontWithColorToolStripMenuItem.Click += new System.EventHandler(this.fontWithColorToolStripMenuItem_Click);
            // 
            // fontWithoutColorToolStripMenuItem
            // 
            this.fontWithoutColorToolStripMenuItem.Name = "fontWithoutColorToolStripMenuItem";
            this.fontWithoutColorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.fontWithoutColorToolStripMenuItem.Text = "Font Without Color";
            this.fontWithoutColorToolStripMenuItem.Click += new System.EventHandler(this.fontWithoutColorToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutNotePadToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = global::NotePad.Properties.Resources.Help_file_icon;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutNotePadToolStripMenuItem
            // 
            this.aboutNotePadToolStripMenuItem.Image = global::NotePad.Properties.Resources.notepad_icon;
            this.aboutNotePadToolStripMenuItem.Name = "aboutNotePadToolStripMenuItem";
            this.aboutNotePadToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutNotePadToolStripMenuItem.Text = "About NotePad";
            // 
            // cCToolStripMenuItem
            // 
            this.cCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cCToolStripMenuItem1});
            this.cCToolStripMenuItem.Name = "cCToolStripMenuItem";
            this.cCToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.cCToolStripMenuItem.Text = "M1";
            // 
            // cCToolStripMenuItem1
            // 
            this.cCToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uToolStripMenuItem,
            this.lToolStripMenuItem});
            this.cCToolStripMenuItem1.Name = "cCToolStripMenuItem1";
            this.cCToolStripMenuItem1.Size = new System.Drawing.Size(90, 22);
            this.cCToolStripMenuItem1.Text = "CC";
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.uToolStripMenuItem.Text = "U";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.lToolStripMenuItem.Text = "L";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(441, 253);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "sa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 277);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNotePadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator findToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontWithColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontWithoutColorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

