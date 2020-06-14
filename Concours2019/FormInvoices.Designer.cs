namespace Concours2019
{
    partial class FormInvoices : Form1
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
            this.cb_allUsers = new System.Windows.Forms.CheckBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.cb_allTypes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_invoice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_totalDays = new System.Windows.Forms.Label();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_allUsers
            // 
            this.cb_allUsers.AutoSize = true;
            this.cb_allUsers.Location = new System.Drawing.Point(105, 100);
            this.cb_allUsers.Name = "cb_allUsers";
            this.cb_allUsers.Size = new System.Drawing.Size(100, 17);
            this.cb_allUsers.TabIndex = 2;
            this.cb_allUsers.Text = "Show all users";
            this.cb_allUsers.UseVisualStyleBackColor = true;
            this.cb_allUsers.CheckedChanged += new System.EventHandler(this.cb_allUsers_CheckedChanged);
            // 
            // txt_fullName
            // 
            this.txt_fullName.Location = new System.Drawing.Point(105, 123);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(100, 22);
            this.txt_fullName.TabIndex = 3;
            // 
            // cb_allTypes
            // 
            this.cb_allTypes.AutoSize = true;
            this.cb_allTypes.Location = new System.Drawing.Point(250, 100);
            this.cb_allTypes.Name = "cb_allTypes";
            this.cb_allTypes.Size = new System.Drawing.Size(100, 17);
            this.cb_allTypes.TabIndex = 4;
            this.cb_allTypes.Text = "Show all types";
            this.cb_allTypes.UseVisualStyleBackColor = true;
            this.cb_allTypes.CheckedChanged += new System.EventHandler(this.cb_allTypes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type:";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(250, 123);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_type.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_search.Location = new System.Drawing.Point(377, 116);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 28);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_invoice.Location = new System.Drawing.Point(34, 203);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.Size = new System.Drawing.Size(632, 150);
            this.dgv_invoice.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Days";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Room Type";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price Per Day";
            this.Column5.Name = "Column5";
            // 
            // lbl_totalDays
            // 
            this.lbl_totalDays.AutoSize = true;
            this.lbl_totalDays.Location = new System.Drawing.Point(34, 177);
            this.lbl_totalDays.Name = "lbl_totalDays";
            this.lbl_totalDays.Size = new System.Drawing.Size(58, 13);
            this.lbl_totalDays.TabIndex = 25;
            this.lbl_totalDays.Text = "Total days";
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Location = new System.Drawing.Point(155, 177);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(75, 13);
            this.lbl_totalAmount.TabIndex = 26;
            this.lbl_totalAmount.Text = "Total amount";
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.White;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_import.Location = new System.Drawing.Point(506, 169);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(160, 28);
            this.btn_import.TabIndex = 27;
            this.btn_import.Text = "Import accommodation";
            this.btn_import.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(338, 169);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(162, 28);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel accommodation";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // FormInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.lbl_totalDays);
            this.Controls.Add(this.dgv_invoice);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_allTypes);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.cb_allUsers);
            this.Name = "FormInvoices";
            this.Text = "FormInvoices";
            this.Controls.SetChildIndex(this.cb_allUsers, 0);
            this.Controls.SetChildIndex(this.txt_fullName, 0);
            this.Controls.SetChildIndex(this.cb_allTypes, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmb_type, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.dgv_invoice, 0);
            this.Controls.SetChildIndex(this.lbl_totalDays, 0);
            this.Controls.SetChildIndex(this.lbl_totalAmount, 0);
            this.Controls.SetChildIndex(this.btn_import, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_allUsers;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.CheckBox cb_allTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_invoice;
        private System.Windows.Forms.Label lbl_totalDays;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}