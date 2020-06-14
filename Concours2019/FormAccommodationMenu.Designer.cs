namespace Concours2019
{
    partial class FormAccommodationMenu
        : Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_invoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accommodation user menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_manage
            // 
            this.btn_manage.BackColor = System.Drawing.Color.White;
            this.btn_manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_manage.Location = new System.Drawing.Point(230, 199);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(226, 33);
            this.btn_manage.TabIndex = 20;
            this.btn_manage.Text = "Manage accommodations";
            this.btn_manage.UseVisualStyleBackColor = false;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_invoices
            // 
            this.btn_invoices.BackColor = System.Drawing.Color.White;
            this.btn_invoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoices.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoices.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_invoices.Location = new System.Drawing.Point(230, 238);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(226, 33);
            this.btn_invoices.TabIndex = 21;
            this.btn_invoices.Text = "Manage invoices";
            this.btn_invoices.UseVisualStyleBackColor = false;
            this.btn_invoices.Click += new System.EventHandler(this.btn_invoices_Click);
            // 
            // FormAccommodationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.label2);
            this.Name = "FormAccommodationMenu";
            this.Text = "FormAccommodationMenu";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_manage, 0);
            this.Controls.SetChildIndex(this.btn_invoices, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_invoices;
    }
}