using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDocumentEditor
{
    public partial class Form1 : Form
    {
        List<InnerForm> childDialogs;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            childDialogs = new List<InnerForm>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                this.textFontFamily.Items.Add(font.Name);
            }
            this.textFontFamily.SelectedIndex = 0;
            this.textFontSize.SelectedIndex = 0;
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childDialogs.Add(new InnerForm(this));
            childDialogs[childDialogs.Count - 1].Show();
        }

        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFileDialog.FileName.Length > 0)
            {
                InnerForm active = (InnerForm)this.ActiveMdiChild;

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        active.SaveToFile(saveFileDialog.FileName, RichTextBoxStreamType.UnicodePlainText);
                        break;

                    case 2:
                        active.SaveToFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                        break;
                }
            }
        }

        private void textBold_Click(object sender, EventArgs e)
        {
            InnerForm active = (InnerForm)this.ActiveMdiChild;
            active.textBold();
        }

        private void textItalic_Click(object sender, EventArgs e)
        {
            InnerForm active = (InnerForm)this.ActiveMdiChild;
            active.textItalic();
        }

        private void textUnderlined_Click(object sender, EventArgs e)
        {
            InnerForm active = (InnerForm)this.ActiveMdiChild;
            active.textUnderline();
        }

        private void textFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((InnerForm)this.ActiveMdiChild != null)
            {
                InnerForm active = (InnerForm)this.ActiveMdiChild;
                active.textFontFamily(this.textFontFamily.SelectedItem.ToString());
            }
        }
        private void textFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((InnerForm)this.ActiveMdiChild != null)
            {
                InnerForm active = (InnerForm)this.ActiveMdiChild;
                active.textFontSize(this.textFontSize.Text);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFileDialog.FileName.Length > 0)
            {
                childDialogs.Add(new InnerForm(this));
                childDialogs[childDialogs.Count - 1].Show();
                
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        childDialogs[childDialogs.Count - 1].OpenFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        break;

                    case 2:
                        childDialogs[childDialogs.Count - 1].OpenFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        break;
                }
            }
        }
        
        //Additions
        
        private void CreateNew_Click(object sender, EventArgs e)
        {
            childDialogs.Add(new InnerForm(this));
            childDialogs[childDialogs.Count - 1].Show();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFileDialog.FileName.Length > 0)
            {
                childDialogs.Add(new InnerForm(this));
                childDialogs[childDialogs.Count - 1].Show();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        childDialogs[childDialogs.Count - 1].OpenFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        break;

                    case 2:
                        childDialogs[childDialogs.Count - 1].OpenFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        break;
                }
            }
        }
        
    }
}
