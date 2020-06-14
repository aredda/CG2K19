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
    public partial class FormGestionUsers : Form1
    {
        private List<User> users;

        public FormGestionUsers()
        {
            InitializeComponent();

            this.Load += FormGestionUsers_Load;
            
            this.txt_role.KeyUp += txt_role_KeyUp;
            this.txt_fullName.KeyUp += txt_fullName_KeyUp;
            this.btn_refresh.Click += btn_refresh_Click;
            this.dgv_user.CellClick += dgv_user_CellClick;

            this.lbl_totalUsers.Text += ": " + DataHandler.Singleton.Users.Count().ToString();
        }

        void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_user.CurrentCell.ColumnIndex != dgv_user.Columns.Count - 1)
                return;

            int i = dgv_user.CurrentCell.RowIndex;

            if (i >= users.Count)
                return;

            Navigation.goTo(this, new FormUserEdit(users[i]));
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            loadUsers(DataHandler.Singleton.Users.ToList());
        }

        void txt_fullName_KeyUp(object sender, KeyEventArgs e)
        {
            string fullName = txt_fullName.Text;

            loadUsers(DataHandler.Singleton.Users.Where(i => i.FullName.Contains(fullName)).ToList());
        }

        void txt_role_KeyUp(object sender, KeyEventArgs e)
        {
            string role = txt_role.Text;

            loadUsers( DataHandler.Singleton.Users.Where(i => i.RoleID.Equals(role)).ToList() );
        }

        void FormGestionUsers_Load(object sender, EventArgs e)
        {
            this.loadUsers( DataHandler.Singleton.Users.ToList() );
        }

        private void loadUsers(List<User> users)
        {
            this.users = users;

            dgv_user.Rows.Clear();

            foreach (User u in users)
                dgv_user.Rows.Add(
                    u.FullName,
                    u.Role.RoleName,
                    u.Email);
        }
    }
}
