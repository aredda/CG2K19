using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours2019
{
    public class DataHandler
    {
        private static CG_Regional_2019Entities model;
        public static User session;

        public static CG_Regional_2019Entities Singleton
        {
            get
            {
                if (model == null)
                    model = new CG_Regional_2019Entities();

                return model;
            }
        }

        public static void Save()
        {
            model.SaveChanges();
        }
        public static void showMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Warning!", MessageBoxButtons.OK,  icon);
        }
    }
}
