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
    public partial class WordProcessor_Page : Form
    {
        private string fileContent;
        public WordProcessor_Page()
        {
            InitializeComponent();
            FormTracker.AddForm(this);//=>important
        }
        public WordProcessor_Page(string fileContent_)//=>important
        {
            InitializeComponent();
            FormTracker.AddForm(this);//=>important
            fileContent = fileContent_;
        }
        private void ResetForm()
        {
            this.viewText.Text = "";
            this.resultText.Text = "";
            this.btnAnalysis.Text = "0 Word";
        }
        private void WordProcessor_Page_Load(object sender, EventArgs e)
        {
            if (fileContent != "")
            {
                viewText.Text = fileContent;
            }
        }

        private void WordProcessor_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormTracker.RemoveForm(this);//=>important

            if (FormTracker.AnyFormOpen())
            {
                // Other forms are open, close this form immediately
                e.Cancel = false;
            }
            else
            {
                // No other forms are open, go back to the welcome form
                e.Cancel = false ;
                Welcome_Page welcome_Page = new Welcome_Page();
                welcome_Page.Show();
            }
        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome_Page welcome_Page = new Welcome_Page();
            welcome_Page.Show();
        }

        private void cleanThisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            //this.Dispose();//=>important
            //WordProcessor_Page wordProcessor_Page = new WordProcessor_Page();
            //wordProcessor_Page.Text = "WordProcessor_Page" + FormTracker.formsCounter.ToString();
            //wordProcessor_Page.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";//=>important
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                viewText.Text = "";
                viewText.Text = File.ReadAllText(filePath);//=>important
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, viewText.Text);//=>important
                MessageBox.Show("File Saved Succesfully", "Save Confirmation"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
