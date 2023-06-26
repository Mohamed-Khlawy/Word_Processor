using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Processor
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
            if (!FormTracker.AnyFormOpen())
            {
                // Other forms are open, close this form immediately
                btnExit_Application.Enabled = true;
            }
            else
            {
                // No other forms are open
                btnExit_Application.Enabled = false;
            }
        }
        private void Welcome_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Page_Click(object sender, EventArgs e)
        {
            WordProcessor_Page wordProcessor_Page = new WordProcessor_Page();
            wordProcessor_Page.Text = "WordProcessor_Page" + FormTracker.formsCounter.ToString();
            wordProcessor_Page.Show();
            this.Hide();
        }

        private void btnOpen_Page_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                WordProcessor_Page wordProcessor_Page = new WordProcessor_Page(fileContent);
                wordProcessor_Page.Text = "WordProcessor_Page" + FormTracker.formsCounter.ToString();
                wordProcessor_Page.Show();
                this.Hide();
            }
            
        }

        private void btnExit_Application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
