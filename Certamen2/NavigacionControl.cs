using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certamen2
{
    internal class NavigacionControl
    {
        public static void Abrir(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
        }
    }
}
