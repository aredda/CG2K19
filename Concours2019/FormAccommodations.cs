using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concours2019
{
    public partial class FormAccommodations : Form1
    {
        private DbSet<AccomdationType> types;

        public FormAccommodations()
        {
            InitializeComponent();

            this.Load += FormAccommodations_Load;
        }

        void FormAccommodations_Load(object sender, EventArgs e)
        {
            types = DataHandler.Singleton.AccomdationTypes;

            cmb_accommodation.DataSource = types.ToList();
            cmb_accommodation.ValueMember = "AccomndationTypeID";
            cmb_accommodation.DisplayMember = "AccomndationType";

            this.cmb_accommodation.SelectedIndexChanged += cmb_accommodation_SelectedIndexChanged;

            pic_image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void cmb_accommodation_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccomdationType t = (AccomdationType)cmb_accommodation.SelectedItem;

            lbl_price.Text = "Current price is " + t.AccomndationPricePerNight;

            loadPictures(t);
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files | *.jpg";

            ofd.ShowDialog();

            txt_picPath.Text = ofd.FileName;
            pic_image.Image = Image.FromFile(ofd.FileName);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txt_picPath.Text, title = txt_picTitle.Text;

                if (path.Length == 0)
                    throw new Exception("You haven't selected any image!");

                if (title.Length == 0)
                    throw new Exception("Specify a title to the selected image!");

                AccomdationType t = (AccomdationType)cmb_accommodation.SelectedItem;

                t.AccomndationPictures.Add(new AccomndationPicture { 
                    AccomndationTypeID=t.AccomndationTypeID,
                    PicturePath=path,
                    PictureTitle=title
                });

                DataHandler.Save();

                DataHandler.showMessage("Picture has been added!", MessageBoxIcon.Information);

                cmb_accommodation_SelectedIndexChanged(null, EventArgs.Empty);
            }
            catch (Exception x)
            {
                DataHandler.showMessage(x.Message, MessageBoxIcon.Warning);
            }
        }

        private void loadPictures(AccomdationType t)
        {
            try
            {
                dataGridView1.Rows.Clear();

                foreach (AccomndationPicture p in t.AccomndationPictures)
                    if( File.Exists(p.PicturePath) )
                        dataGridView1.Rows.Add(Image.FromFile(p.PicturePath), p.PictureTitle);
            }
            catch (Exception)
            {}
        }
    }
}
