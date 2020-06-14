using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours2019
{
    public partial class FormLogin 
        : Form1
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_email.Text;
                string password = txt_password.Text;

                if (email.Length == 0 || password.Length == 0)
                    throw new Exception("Complete all of login information!");

                User u = DataHandler.Singleton.Users.Single(i => i.Email.CompareTo(email) == 0);

                if (u.Password.CompareTo(password) != 0)
                    throw new Exception("Wrong password!");

                DataHandler.session = u;

                Navigation.forms.Add(this);

                if (u.RoleID == "A")
                    Navigation.goTo(this, new FormGestionUsers());
                else
                    Navigation.goTo(this, new FormAccommodationMenu());
            }
            catch (InvalidOperationException)
            {
                DataHandler.showMessage("User doesn't exist!", MessageBoxIcon.Warning);
            }
            catch (Exception x)
            {
                DataHandler.showMessage(x.Message, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
