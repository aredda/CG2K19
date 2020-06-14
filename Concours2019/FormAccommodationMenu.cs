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
    public partial class FormAccommodationMenu 
        : Form1
    {
        public FormAccommodationMenu()
        {
            InitializeComponent();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            Navigation.goTo(this, new FormAccommodations());
        }

        private void btn_invoices_Click(object sender, EventArgs e)
        {
            Navigation.goTo(this, new FormInvoices());
        }
    }
}
