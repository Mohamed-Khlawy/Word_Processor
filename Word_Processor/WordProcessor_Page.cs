using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Processor
{
    public partial class WordProcessor_Page : Form
    {
        public WordProcessor_Page()
        {
            InitializeComponent();
        }

        private void WordProcessor_Page1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome_Page welcome_Page = new Welcome_Page();
            welcome_Page.Show();
        }

        private void cleanThisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            WordProcessor_Page wordProcessor_Page = new WordProcessor_Page();
            wordProcessor_Page.Show();
        }
    }
}
