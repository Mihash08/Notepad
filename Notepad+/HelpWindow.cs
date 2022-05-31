using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class HelpWindow : Form
    {
        private string[] _helptext = new string[2];
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void HelpWindow_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            tabPage1.Text = "Shortcuts";
            tabPage2.Text = "How buttons work";
            tabControl1.TabPages.Add("");
        }
    }
}
