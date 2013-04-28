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
    public partial class InnerForm : Form
    {
        Form1 parent;

        public InnerForm()
        {
            InitializeComponent();
        }
        public InnerForm(Form1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.parent = parent;
        }
        public void SaveToFile(String fileName, RichTextBoxStreamType fileType)
        {
            richTextBox1.SaveFile(fileName, fileType);
        }

        public void OpenFile(String fileName, RichTextBoxStreamType fileType)
        {
            richTextBox1.LoadFile(fileName, fileType);
        }
        public void textBold()
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Bold == true)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Bold;
            }

            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }
        public void textItalic()
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Italic == true)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Italic;
            }

            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }
        public void textUnderline()
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Underline == true)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }
        public void textFontFamily(string fontName)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(new FontFamily(fontName), currentFont.Size, currentFont.Bold ? FontStyle.Bold : currentFont.Italic ? FontStyle.Italic : currentFont.Underline ? FontStyle.Underline : FontStyle.Regular);
        }
        public void textFontSize(string fontSize)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, Convert.ToInt16(fontSize), currentFont.Bold ? FontStyle.Bold : currentFont.Italic ? FontStyle.Italic : currentFont.Underline ? FontStyle.Underline : FontStyle.Regular);
        }
    }
}
