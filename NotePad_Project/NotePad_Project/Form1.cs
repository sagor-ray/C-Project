using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad_Project
{
    public partial class Form1 : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    MessageBox.Show("You need to save this current file first!!");
                }
                else
                {
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "untitled";
                }
            
        }

       
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                        this.Text = openFileDialog.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Please Save the current file!!");
                }
           
        }

        void saveFile()
        {
           
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File(*.txt) | *.txt";
                    //saveFileDialog.Filter = "Pdf File(*.pdf) | *.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                        this.Text = saveFileDialog.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("The file is empty!!");
                }
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if(!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFile();
                }
                else
                {
                    this.Close();
                }
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
              if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fontDialog.Font;
                }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
