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
    public partial class FormUserEdit : Form1
    {
        private User target;

        public FormUserEdit()
        {
            InitializeComponent();
        }
        public FormUserEdit(User target)
            : this()
        {
            this.target = target;
            this.Load += FormUserEdit_Load;
        }

        void FormUserEdit_Load(object sender, EventArgs e)
        {
            txt_email.Text = target.Email;
            txt_email.Enabled = false;
            
            txt_fullName.Text = target.FullName;
            txt_mobile.Text = target.MobileNo;
            dtp_birth.Value = target.DateOfBirth;

            cmb_gender.Items.AddRange(new object[]{"Male", "Female"});
            cmb_gender.SelectedIndex = 0;
            cmb_role.DataSource = DataHandler.Singleton.Roles.ToList();
            cmb_role.ValueMember = "RoleID";
            cmb_role.DisplayMember = "RoleName";

            this.btn_save.Click += btn_save_Click;
        }

        void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_email.TextLength == 0)
                    throw new Exception("Email is necessary!");

                target.FullName = txt_fullName.Text;
                target.Gender = cmb_gender.SelectedText.ToString();
                target.DateOfBirth = dtp_birth.Value;
                target.RoleID = cmb_role.SelectedValue.ToString();
                target.MobileNo = txt_mobile.Text;

                if (txt_password.TextLength != 0)
                {
                    if (!txt_password.Text.Equals(txt_confirmPassword.Text))
                        throw new Exception("Password's confirmation doesn't match the password!");
                        
                    target.Password = txt_password.Text;
                }

                DataHandler.Save();

                DataHandler.showMessage("Changes are successfully changed!", MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                DataHandler.showMessage(x.Message, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Navigation.goBack(this);
        }
    }
}
