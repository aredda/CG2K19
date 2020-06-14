namespace Concours2019
{
    partial class FormGestionUsers : Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.btn_export = new System.Windows.Forms.Button();
            this.lbl_totalUsers = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sort and filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(94, 129);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(100, 22);
            this.txt_role.TabIndex = 5;
            // 
            // txt_fullName
            // 
            this.txt_fullName.Location = new System.Drawing.Point(94, 157);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(100, 22);
            this.txt_fullName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sort by";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_refresh.Location = new System.Drawing.Point(200, 129);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 50);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // dgv_user
            // 
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_user.Location = new System.Drawing.Point(37, 185);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(629, 150);
            this.dgv_user.TabIndex = 9;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(570, 146);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(96, 33);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "Export CSV";
            this.btn_export.UseVisualStyleBackColor = false;
            // 
            // lbl_totalUsers
            // 
            this.lbl_totalUsers.AutoSize = true;
            this.lbl_totalUsers.Location = new System.Drawing.Point(302, 166);
            this.lbl_totalUsers.Name = "lbl_totalUsers";
            this.lbl_totalUsers.Size = new System.Drawing.Size(62, 13);
            this.lbl_totalUsers.TabIndex = 11;
            this.lbl_totalUsers.Text = "Total users";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Role";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Edit";
            // 
            // FormGestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.lbl_totalUsers);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormGestionUsers";
            this.Text = "FormGestionUsers";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_role, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_fullName, 0);
            this.Controls.SetChildIndex(this.btn_refresh, 0);
            this.Controls.SetChildIndex(this.dgv_user, 0);
            this.Controls.SetChildIndex(this.btn_export, 0);
            this.Controls.SetChildIndex(this.lbl_totalUsers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label lbl_totalUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;

    }
}