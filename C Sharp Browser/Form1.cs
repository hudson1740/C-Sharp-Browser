using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void faderButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(faderTextBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            webBrowser1.GoForward();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            faderTextBox1.Text = "http://www.google.com";
            webBrowser1.Navigate("http://Www.google.com");
        }

        private void faderTheme1_Click(object sender, EventArgs e)
        {
         
        }

        private void faderButton2_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(toolStripTextBox1.Text);
            listView1.Items.Add(toolStripTextBox1.Text);
        }

        private void faderButton3_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("You need to select an item");
            }
        }

        private void faderTheme2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(faderTextBox1.Text);
            listView1.Items.Add(faderTextBox1.Text);
            MessageBox.Show("You Have Added A New BookMark Successfully");
                }

        private void faderTextBox2_Click(object sender, EventArgs e)
        {
          

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //copy
          
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //paste
            
        }
    }
    }
    



