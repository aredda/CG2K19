using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours2019
{
    public class Navigation
    {
        public static List<Form> forms = new List<Form>();

        public static void goTo(Form current, Form destination)
        {
            current.Hide();
            destination.Show();

            destination.FormClosing += destination_FormClosing;

            forms.Add(destination);
        }

        static void destination_FormClosing(object sender, FormClosingEventArgs e)
        {
            Navigation.goBack((Form)sender);
        }

        public static void goBack(Form current)
        {
            forms.Remove(current);
            current.Hide();

            if (forms.Count > 0)
                forms.Last().Show();
        }

        public static void goHome()
        {
            while (forms.Count > 1)
            {
                forms.Last().Dispose();
                forms.Remove(forms.Last());
            }

            forms.First().Show();
        }
    }
}
