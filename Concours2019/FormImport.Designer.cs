namespace Concours2019
{
    partial class FormImport : Form1
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
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CSV list of bookings";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(165, 155);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(247, 22);
            this.txt_path.TabIndex = 3;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.White;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_browse.Location = new System.Drawing.Point(427, 148);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(96, 33);
            this.btn_browse.TabIndex = 20;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Location = new System.Drawing.Point(165, 262);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 33);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(267, 262);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 33);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label2);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_path, 0);
            this.Controls.SetChildIndex(this.btn_browse, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}