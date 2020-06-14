namespace Concours2019
{
    partial class Form1
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.pnl_head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.SeaGreen;
            this.pnl_head.Controls.Add(this.pnl_body);
            this.pnl_head.Controls.Add(this.btn_logout);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Location = new System.Drawing.Point(1, 0);
            this.pnl_head.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_head.Size = new System.Drawing.Size(698, 76);
            this.pnl_head.TabIndex = 0;
            // 
            // pnl_body
            // 
            this.pnl_body.Location = new System.Drawing.Point(0, 79);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(30);
            this.pnl_body.Size = new System.Drawing.Size(698, 274);
            this.pnl_body.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_logout.Location = new System.Drawing.Point(579, 23);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(96, 33);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.lbl_footer);
            this.panel2.Location = new System.Drawing.Point(1, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 40);
            this.panel2.TabIndex = 1;
            // 
            // lbl_footer
            // 
            this.lbl_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_footer.ForeColor = System.Drawing.Color.White;
            this.lbl_footer.Location = new System.Drawing.Point(0, 0);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(698, 40);
            this.lbl_footer.TabIndex = 2;
            this.lbl_footer.Text = "Concours General 2019 - Selection regionale";
            this.lbl_footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_head);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_head;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_footer;
        protected System.Windows.Forms.Panel pnl_body;
    }
}

