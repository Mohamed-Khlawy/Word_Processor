using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Processor
{
    public static class FormTracker
    {
        private static List<Form> openForms = new List<Form>();
        public static int formsCounter = 0;

        public static void AddForm(Form form)
        {
            openForms.Add(form);
            form.FormClosed += Form_FormClosed;
            formsCounter++;
        }

        public static void RemoveForm(Form form)
        {
            openForms.Remove(form);
            form.FormClosed -= Form_FormClosed;
            formsCounter--;
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form closedForm)
            {
                RemoveForm(closedForm);
            }
        }

        public static bool AnyFormOpen()
        {
            return openForms.Count > 0;
        }
    }
}
