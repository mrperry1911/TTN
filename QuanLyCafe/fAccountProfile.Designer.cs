namespace QuanLyCafe
{
    partial class faccountprofile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fexit = new System.Windows.Forms.Button();
            this.fupdate = new System.Windows.Forms.Button();
            this.pnrepass = new System.Windows.Forms.Panel();
            this.tbrepass = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbnewpass = new System.Windows.Forms.TextBox();
            this.fnewpass = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.fpass = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.fdisplayname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.floginname = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnrepass.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(762, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fexit);
            this.panel2.Controls.Add(this.fupdate);
            this.panel2.Controls.Add(this.pnrepass);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 350);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fexit
            // 
            this.fexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fexit.Location = new System.Drawing.Point(298, 314);
            this.fexit.Name = "fexit";
            this.fexit.Size = new System.Drawing.Size(75, 23);
            this.fexit.TabIndex = 8;
            this.fexit.Text = "Thoát";
            this.fexit.UseVisualStyleBackColor = true;
            this.fexit.Click += new System.EventHandler(this.fexit_Click);
            // 
            // fupdate
            // 
            this.fupdate.Location = new System.Drawing.Point(179, 314);
            this.fupdate.Name = "fupdate";
            this.fupdate.Size = new System.Drawing.Size(75, 26);
            this.fupdate.TabIndex = 7;
            this.fupdate.Text = "Cập nhập";
            this.fupdate.UseVisualStyleBackColor = true;
            this.fupdate.Click += new System.EventHandler(this.fupdate_Click);
            // 
            // pnrepass
            // 
            this.pnrepass.Controls.Add(this.tbrepass);
            this.pnrepass.Controls.Add(this.confirm);
            this.pnrepass.Location = new System.Drawing.Point(14, 255);
            this.pnrepass.Name = "pnrepass";
            this.pnrepass.Size = new System.Drawing.Size(371, 40);
            this.pnrepass.TabIndex = 6;
            // 
            // tbrepass
            // 
            this.tbrepass.Location = new System.Drawing.Point(147, 8);
            this.tbrepass.Name = "tbrepass";
            this.tbrepass.Size = new System.Drawing.Size(198, 20);
            this.tbrepass.TabIndex = 1;
            this.tbrepass.TextChanged += new System.EventHandler(this.tbrepass_TextChanged);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(3, 9);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(81, 19);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "Nhập lại :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbnewpass);
            this.panel6.Controls.Add(this.fnewpass);
            this.panel6.Location = new System.Drawing.Point(14, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 40);
            this.panel6.TabIndex = 5;
            // 
            // tbnewpass
            // 
            this.tbnewpass.Location = new System.Drawing.Point(147, 8);
            this.tbnewpass.Name = "tbnewpass";
            this.tbnewpass.Size = new System.Drawing.Size(198, 20);
            this.tbnewpass.TabIndex = 1;
            // 
            // fnewpass
            // 
            this.fnewpass.AutoSize = true;
            this.fnewpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnewpass.Location = new System.Drawing.Point(3, 9);
            this.fnewpass.Name = "fnewpass";
            this.fnewpass.Size = new System.Drawing.Size(121, 19);
            this.fnewpass.TabIndex = 0;
            this.fnewpass.Text = "Mật khẩu mới :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbPassword);
            this.panel5.Controls.Add(this.fpass);
            this.panel5.Location = new System.Drawing.Point(14, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 40);
            this.panel5.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(147, 8);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(198, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // fpass
            // 
            this.fpass.AutoSize = true;
            this.fpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpass.Location = new System.Drawing.Point(3, 9);
            this.fpass.Name = "fpass";
            this.fpass.Size = new System.Drawing.Size(88, 19);
            this.fpass.TabIndex = 0;
            this.fpass.Text = "Mật khẩu :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbDisplayName);
            this.panel4.Controls.Add(this.fdisplayname);
            this.panel4.Location = new System.Drawing.Point(14, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 37);
            this.panel4.TabIndex = 3;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(147, 8);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(198, 20);
            this.tbDisplayName.TabIndex = 1;
            // 
            // fdisplayname
            // 
            this.fdisplayname.AutoSize = true;
            this.fdisplayname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdisplayname.Location = new System.Drawing.Point(3, 9);
            this.fdisplayname.Name = "fdisplayname";
            this.fdisplayname.Size = new System.Drawing.Size(108, 19);
            this.fdisplayname.TabIndex = 0;
            this.fdisplayname.Text = "Tên hiển thị :";
            this.fdisplayname.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbUserName);
            this.panel3.Controls.Add(this.floginname);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 40);
            this.panel3.TabIndex = 2;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(147, 8);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(198, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // floginname
            // 
            this.floginname.AutoSize = true;
            this.floginname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floginname.Location = new System.Drawing.Point(3, 9);
            this.floginname.Name = "floginname";
            this.floginname.Size = new System.Drawing.Size(134, 19);
            this.floginname.TabIndex = 0;
            this.floginname.Text = "Tên đăng nhập :";
            // 
            // faccountprofile
            // 
            this.AcceptButton = this.fupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fexit;
            this.ClientSize = new System.Drawing.Size(438, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "faccountprofile";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.fAccountProfile_Load);
            this.panel2.ResumeLayout(false);
            this.pnrepass.ResumeLayout(false);
            this.pnrepass.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label fpass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label fdisplayname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label floginname;
        private System.Windows.Forms.Panel pnrepass;
        private System.Windows.Forms.TextBox tbrepass;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbnewpass;
        private System.Windows.Forms.Label fnewpass;
        private System.Windows.Forms.Button fexit;
        private System.Windows.Forms.Button fupdate;
    }
}