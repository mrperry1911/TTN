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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.floginname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fdisplayname = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.fpass = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.fnewpass = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Label();
            this.fupdate = new System.Windows.Forms.Button();
            this.fexit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.floginname);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 40);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.fdisplayname);
            this.panel4.Location = new System.Drawing.Point(14, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 37);
            this.panel4.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 1;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.fpass);
            this.panel5.Location = new System.Drawing.Point(14, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 40);
            this.panel5.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 1;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.fnewpass);
            this.panel6.Location = new System.Drawing.Point(14, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 40);
            this.panel6.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 1;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox5);
            this.panel7.Controls.Add(this.confirm);
            this.panel7.Location = new System.Drawing.Point(14, 255);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(371, 40);
            this.panel7.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 20);
            this.textBox5.TabIndex = 1;
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
            // fupdate
            // 
            this.fupdate.Location = new System.Drawing.Point(179, 314);
            this.fupdate.Name = "fupdate";
            this.fupdate.Size = new System.Drawing.Size(75, 26);
            this.fupdate.TabIndex = 7;
            this.fupdate.Text = "Cập nhập";
            this.fupdate.UseVisualStyleBackColor = true;
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label fpass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label fdisplayname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label floginname;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label fnewpass;
        private System.Windows.Forms.Button fexit;
        private System.Windows.Forms.Button fupdate;
    }
}