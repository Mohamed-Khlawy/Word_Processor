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

        private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewText.TextAlign = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewText.TextAlign = HorizontalAlignment.Center;
        }

        private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewText.TextAlign = HorizontalAlignment.Right;
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            { 
                viewText.BackColor = colorDialog.Color;
            }
        }

        private void foToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                viewText.ForeColor = colorDialog.Color;
            }
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                viewText.Font = fontDialog.Font;
            }
        }
        private void zoom1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            float newSize = 0.25f;//=>important
            viewText.Font = new Font(viewText.Font.FontFamily,
                            viewText.Font.Size * newSize, viewText.Font.Style);
        }
        private void zoom2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float newSize = 0.50f;//=>important
            viewText.Font = new Font(viewText.Font.FontFamily,
                            viewText.Font.Size * newSize, viewText.Font.Style);
        }
        private void zoom3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float newSize = 0.75f;//=>important
            viewText.Font = new Font(viewText.Font.FontFamily,
                            viewText.Font.Size * newSize, viewText.Font.Style);
        }

        private void zoom4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float newSize = 1.0f;//=>important
            viewText.Font = new Font(viewText.Font.FontFamily,
                            viewText.Font.Size * newSize, viewText.Font.Style);
        }

        private void zoom5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float newSize = 2.0f;//=>important
            viewText.Font = new Font(viewText.Font.FontFamily,
                viewText.Font.Size * newSize, viewText.Font.Style);
        }
    }
}
