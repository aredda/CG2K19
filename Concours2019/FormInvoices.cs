using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours2019
{
    public partial class FormInvoices : Form1
    {
        DbSet<AccomdationData> accomdations;

        public FormInvoices()
        {
            InitializeComponent();

            this.Load += FormInvoices_Load;
        }

        void FormInvoices_Load(object sender, EventArgs e)
        {
            accomdations = DataHandler.Singleton.AccomdationDatas;

            cmb_type.DataSource = DataHandler.Singleton.AccomdationTypes.ToList();
            cmb_type.ValueMember = "AccomndationTypeID";
            cmb_type.DisplayMember = "AccomndationType";

            loadAccomdations(accomdations.ToList());
        }

        private void loadAccomdations(List<AccomdationData> data)
        {
            dgv_invoice.Rows.Clear();

            foreach( AccomdationData d in data )
                dgv_invoice.Rows.Add(
                    d.User.FullName,
                    d.StarDate,
                    d.EndDate != null ? d.EndDate.Value.Subtract(d.StarDate.Value).Days.ToString() : "-",
                    d.AccomdationType.AccomndationType,
                    d.AccomdationType.AccomndationPricePerNight);

            lbl_totalDays.Text = "Total days: " + data.Sum(i => i.EndDate.Value.Subtract(i.StarDate.Value).Days);
            lbl_totalAmount.Text = "Total amount: " + data.Sum(i => i.AccomdationType.AccomndationPricePerNight);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string fullName = txt_fullName.Text;
            AccomdationType type = (AccomdationType)cmb_type.SelectedItem;

            List<AccomdationData> data = accomdations.ToList();
            
            if (!cb_allUsers.Checked)
                data = accomdations.Where( i => i.User.FullName.Contains(fullName) ).ToList();

            if (!cb_allTypes.Checked)
                data = data.Where(i => i.AccomdationTypeID.Equals(type.AccomndationTypeID)).ToList();

            loadAccomdations( data );
        }

        private void cb_allTypes_CheckedChanged(object sender, EventArgs e)
        {
            cmb_type.Enabled = !cb_allTypes.Checked;
        }

        private void cb_allUsers_CheckedChanged(object sender, EventArgs e)
        {
            txt_fullName.Enabled = !cb_allUsers.Checked;
        }
    }
}
