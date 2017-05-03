using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMDI
{
    public partial class Form1 : Form
    {
        public Form1(Form formChild)
        {
            InitializeComponent();
            formChild.MdiParent = this;
            formChild.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Home());
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Create());
        }
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new List());
        }

        private void ShowChildForm(Form form)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            form.MdiParent = this;
            form.Show();
        }
    }
}
