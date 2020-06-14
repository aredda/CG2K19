namespace Concours2019
{
    partial class FormUserEdit : Form1
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(177, 119);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(121, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_fullName
            // 
            this.txt_fullName.Location = new System.Drawing.Point(177, 147);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(121, 22);
            this.txt_fullName.TabIndex = 3;
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Location = new System.Drawing.Point(177, 175);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(121, 21);
            this.cmb_gender.TabIndex = 4;
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(177, 202);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(121, 21);
            this.cmb_role.TabIndex = 5;
            // 
            // dtp_birth
            // 
            this.dtp_birth.Location = new System.Drawing.Point(177, 229);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(121, 22);
            this.dtp_birth.TabIndex = 6;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(177, 257);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(121, 22);
            this.txt_mobile.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mobile:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(545, 175);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 22);
            this.txt_password.TabIndex = 14;
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(545, 203);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(121, 22);
            this.txt_confirmPassword.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Confirm password:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(570, 287);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 33);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Location = new System.Drawing.Point(468, 287);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 33);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // FormUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.dtp_birth);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.txt_email);
            this.Name = "FormUserEdit";
            this.Text = "FormUserEdit";
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.txt_fullName, 0);
            this.Controls.SetChildIndex(this.cmb_gender, 0);
            this.Controls.SetChildIndex(this.cmb_role, 0);
            this.Controls.SetChildIndex(this.dtp_birth, 0);
            this.Controls.SetChildIndex(this.txt_mobile, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.Controls.SetChildIndex(this.txt_confirmPassword, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}