using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewlineRemovalUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.KeyPress += SelectAll;
            txtOutput.KeyPress += SelectAll;
        }

        private void SelectAll(object sender, KeyPressEventArgs e)
        {
            if ((System.Windows.Forms.Control.ModifierKeys ==
 Keys.Control) && (e.KeyChar == (char)Keys.A))
                ((TextBox)sender).SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            input = input.Replace("\r", "");
            input = input.Replace("\n", "");
            txtOutput.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
            txtOutput.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOutput.SelectAll();
            txtOutput.Copy();
        }
    }
}
