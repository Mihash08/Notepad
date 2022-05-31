using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class SaveOrExit : Form
    {
        public SaveOrExit(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveOrExit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                (Application.OpenForms["Form1"] as Form1).CloseTabMessage();
            }
            Close();
        }

        private void saveAndExit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                (Application.OpenForms["Form1"] as Form1).SaveThisFile();
                (Application.OpenForms["Form1"] as Form1).CloseTabMessage();
            }
            Close();
        }
    }
}
