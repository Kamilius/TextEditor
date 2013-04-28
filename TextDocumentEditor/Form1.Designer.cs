namespace TextDocumentEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolbar = new System.Windows.Forms.ToolStrip();
            this.CreateNew = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.Redo = new System.Windows.Forms.ToolStripButton();
            this.textEditingToolbar = new System.Windows.Forms.ToolStrip();
            this.textBold = new System.Windows.Forms.ToolStripButton();
            this.textItalic = new System.Windows.Forms.ToolStripButton();
            this.textUnderlined = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.textFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.textFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.textColor = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu.SuspendLayout();
            this.mainMenuToolbar.SuspendLayout();
            this.textEditingToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "New file...";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open file...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "Save";
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileAsToolStripMenuItem.Text = "Save file as...";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveFileAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(117, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // mainMenuToolbar
            // 
            this.mainMenuToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNew,
            this.Open,
            this.Save,
            this.toolStripSeparator3,
            this.Cut,
            this.Copy,
            this.Paste,
            this.toolStripSeparator4,
            this.Undo,
            this.Redo});
            this.mainMenuToolbar.Location = new System.Drawing.Point(0, 24);
            this.mainMenuToolbar.Name = "mainMenuToolbar";
            this.mainMenuToolbar.Size = new System.Drawing.Size(784, 25);
            this.mainMenuToolbar.TabIndex = 1;
            this.mainMenuToolbar.Text = "toolStrip1";
            // 
            // CreateNew
            // 
            this.CreateNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateNew.Image = ((System.Drawing.Image)(resources.GetObject("CreateNew.Image")));
            this.CreateNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(23, 22);
            this.CreateNew.Text = "Create new...";
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "Open";
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Cut
            // 
            this.Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(23, 22);
            this.Cut.Text = "Cut";
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(23, 22);
            this.Copy.Text = "Copy";
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(23, 22);
            this.Paste.Text = "Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Undo
            // 
            this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo.Image = ((System.Drawing.Image)(resources.GetObject("Undo.Image")));
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(23, 22);
            this.Undo.Text = "Undo";
            // 
            // Redo
            // 
            this.Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Redo.Image = ((System.Drawing.Image)(resources.GetObject("Redo.Image")));
            this.Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(23, 22);
            this.Redo.Text = "Redo";
            // 
            // textEditingToolbar
            // 
            this.textEditingToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBold,
            this.textItalic,
            this.textUnderlined,
            this.toolStripSeparator6,
            this.textFontFamily,
            this.textFontSize,
            this.toolStripSeparator7,
            this.textColor});
            this.textEditingToolbar.Location = new System.Drawing.Point(0, 49);
            this.textEditingToolbar.Name = "textEditingToolbar";
            this.textEditingToolbar.Size = new System.Drawing.Size(784, 25);
            this.textEditingToolbar.TabIndex = 2;
            this.textEditingToolbar.Text = "toolStrip2";
            // 
            // textBold
            // 
            this.textBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textBold.Image = ((System.Drawing.Image)(resources.GetObject("textBold.Image")));
            this.textBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textBold.Name = "textBold";
            this.textBold.Size = new System.Drawing.Size(23, 22);
            this.textBold.Text = "Bold";
            this.textBold.Click += new System.EventHandler(this.textBold_Click);
            // 
            // textItalic
            // 
            this.textItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textItalic.Image = ((System.Drawing.Image)(resources.GetObject("textItalic.Image")));
            this.textItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textItalic.Name = "textItalic";
            this.textItalic.Size = new System.Drawing.Size(23, 22);
            this.textItalic.Text = "Italic";
            this.textItalic.Click += new System.EventHandler(this.textItalic_Click);
            // 
            // textUnderlined
            // 
            this.textUnderlined.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textUnderlined.Image = ((System.Drawing.Image)(resources.GetObject("textUnderlined.Image")));
            this.textUnderlined.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textUnderlined.Name = "textUnderlined";
            this.textUnderlined.Size = new System.Drawing.Size(23, 22);
            this.textUnderlined.Text = "Underline";
            this.textUnderlined.Click += new System.EventHandler(this.textUnderlined_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // textFontFamily
            // 
            this.textFontFamily.Name = "textFontFamily";
            this.textFontFamily.Size = new System.Drawing.Size(121, 25);
            this.textFontFamily.SelectedIndexChanged += new System.EventHandler(this.textFontFamily_SelectedIndexChanged);
            // 
            // textFontSize
            // 
            this.textFontSize.DropDownWidth = 25;
            this.textFontSize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.textFontSize.Name = "textFontSize";
            this.textFontSize.Size = new System.Drawing.Size(75, 25);
            this.textFontSize.SelectedIndexChanged += new System.EventHandler(this.textFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // textColor
            // 
            this.textColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textColor.Image = ((System.Drawing.Image)(resources.GetObject("textColor.Image")));
            this.textColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(23, 22);
            this.textColor.Text = "text color";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text file|*.txt|Rich text format|*.rtf";
            this.saveFileDialog.InitialDirectory = "d:\\";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save file as...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text files|*.txt|Rich file type|*.rtf";
            this.openFileDialog.InitialDirectory = "d:\\";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.textEditingToolbar);
            this.Controls.Add(this.mainMenuToolbar);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "RichTextEditor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainMenuToolbar.ResumeLayout(false);
            this.mainMenuToolbar.PerformLayout();
            this.textEditingToolbar.ResumeLayout(false);
            this.textEditingToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainMenuToolbar;
        private System.Windows.Forms.ToolStripButton CreateNew;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Cut;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripButton Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.ToolStripButton Redo;
        private System.Windows.Forms.ToolStrip textEditingToolbar;
        private System.Windows.Forms.ToolStripButton textBold;
        private System.Windows.Forms.ToolStripButton textItalic;
        private System.Windows.Forms.ToolStripButton textUnderlined;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox textFontFamily;
        private System.Windows.Forms.ToolStripComboBox textFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton textColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

