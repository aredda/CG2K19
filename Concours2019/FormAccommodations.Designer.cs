namespace Concours2019
{
    partial class FormAccommodations : Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_accommodation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_picPath = new System.Windows.Forms.TextBox();
            this.txt_picTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_accommodation
            // 
            this.cmb_accommodation.FormattingEnabled = true;
            this.cmb_accommodation.Location = new System.Drawing.Point(165, 112);
            this.cmb_accommodation.Name = "cmb_accommodation";
            this.cmb_accommodation.Size = new System.Drawing.Size(150, 21);
            this.cmb_accommodation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select accommodation:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(162, 136);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "label3";
            // 
            // txt_picPath
            // 
            this.txt_picPath.Location = new System.Drawing.Point(165, 161);
            this.txt_picPath.Name = "txt_picPath";
            this.txt_picPath.Size = new System.Drawing.Size(150, 22);
            this.txt_picPath.TabIndex = 5;
            // 
            // txt_picTitle
            // 
            this.txt_picTitle.Location = new System.Drawing.Point(165, 189);
            this.txt_picTitle.Name = "txt_picTitle";
            this.txt_picTitle.Size = new System.Drawing.Size(150, 22);
            this.txt_picTitle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add new picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Picture title:";
            // 
            // pic_image
            // 
            this.pic_image.Location = new System.Drawing.Point(515, 107);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(151, 110);
            this.pic_image.TabIndex = 9;
            this.pic_image.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_new.Location = new System.Drawing.Point(321, 107);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(65, 28);
            this.btn_new.TabIndex = 21;
            this.btn_new.Text = "+";
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.White;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_browse.Location = new System.Drawing.Point(321, 155);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(91, 28);
            this.btn_browse.TabIndex = 22;
            this.btn_browse.Text = "Browse..";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Location = new System.Drawing.Point(321, 189);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 28);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(34, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 100);
            this.label6.TabIndex = 25;
            this.label6.Text = "Current list of pictures for this accommodation:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(109, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 130);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Picture";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.pic_image);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_picTitle);
            this.Controls.Add(this.txt_picPath);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_accommodation);
            this.Name = "FormAccommodations";
            this.Text = "FormAccommodations";
            this.Controls.SetChildIndex(this.cmb_accommodation, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbl_price, 0);
            this.Controls.SetChildIndex(this.txt_picPath, 0);
            this.Controls.SetChildIndex(this.txt_picTitle, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pic_image, 0);
            this.Controls.SetChildIndex(this.btn_new, 0);
            this.Controls.SetChildIndex(this.btn_browse, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_accommodation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_picPath;
        private System.Windows.Forms.TextBox txt_picTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_image;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}