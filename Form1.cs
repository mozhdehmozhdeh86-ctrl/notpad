using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace wordpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Filter = "All document|*.txt;*.doc;*.docx;";
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1. Filter = "All document|*.txt;*.doc;*.docx;";
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile( openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
        
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string find=Interaction.InputBox("what do you want to find??", "find", "", 0, 0);
            int p=  richTextBox1.Find(find, 0, richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
            MessageBox.Show(p.ToString());
        }
         int place = 1;
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
         {
             string find = Interaction.InputBox("what do you want to find??", "find", "", 0, 0);
             
                 int p = richTextBox1.Find(find, place , richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                 p = place++;
            
             MessageBox.Show(place.ToString());
         }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font= fontDialog1.Font;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            rightToolStripMenuItem.Checked = true;
           centerToolStripMenuItem.Checked = false;
           leftToolStripMenuItem.Checked = false;
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolbarToolStripMenuItem.Checked == true)
                toolStrip1.Visible = true;
            else
            {
                toolbarToolStripMenuItem.Checked = false;
                toolStrip1.Visible = false;
            }
  
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked == true)
                statusStrip1.Visible = true;
            else
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.SelectAll();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            rightToolStripMenuItem.Checked = false;
            centerToolStripMenuItem.Checked = false;
            leftToolStripMenuItem.Checked = true;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            rightToolStripMenuItem.Checked = false;
            centerToolStripMenuItem.Checked = true;
            leftToolStripMenuItem.Checked = false;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void alignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1=new PrintDialog();
            printDialog1.ShowDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            string x = Clipboard.GetText();
            richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, x);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
