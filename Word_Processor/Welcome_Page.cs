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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void btnNew_Page_Click(object sender, EventArgs e)
        {
            WordProcessor_Page wordProcessor_Page = new WordProcessor_Page();
            wordProcessor_Page.Show();
            this.Hide();
        }
    }
}
