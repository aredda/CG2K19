using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours2019
{
    public partial class FormImport : Form1
    {
        public FormImport()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog csvOfd = new OpenFileDialog();
            csvOfd.Filter = "CSV FILES ONLY | *.csv";

            csvOfd.ShowDialog();

            txt_path.Text = csvOfd.FileName;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Navigation.goBack(this);
        }
    }
}
