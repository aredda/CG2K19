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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            if (this is FormLogin)
                btn_logout.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Navigation.goHome();
        }
    }
}
