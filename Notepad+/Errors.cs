using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Errors : Form
    {
        public Errors(string[] errors)
        {
            InitializeComponent();
            listBox1.Items.AddRange(errors);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
