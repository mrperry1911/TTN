namespace QuanLyCafe
{
    partial class ftablemanager
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalfood = new System.Windows.Forms.NumericUpDown();
            this.addFood = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.switchboxtotal = new System.Windows.Forms.NumericUpDown();
            this.switchbox = new System.Windows.Forms.Button();
            this.saletotal = new System.Windows.Forms.NumericUpDown();
            this.sale = new System.Windows.Forms.Button();
            this.thanhtoancheckout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodTableAdapter1 = new QuanLyCafe.QuanLyCafeDataSetTableAdapters.FoodTableAdapter();
            this.listView2 = new System.Windows.Forms.ListView();
            this.flpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalfood)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchboxtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saletotal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 346);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Location = new System.Drawing.Point(268, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 187);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.totalfood);
            this.panel5.Controls.Add(this.addFood);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Location = new System.Drawing.Point(268, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 53);
            this.panel5.TabIndex = 4;
            // 
            // totalfood
            // 
            this.totalfood.Location = new System.Drawing.Point(228, 19);
            this.totalfood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.totalfood.Name = "totalfood";
            this.totalfood.Size = new System.Drawing.Size(44, 20);
            this.totalfood.TabIndex = 3;
            this.totalfood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addFood
            // 
            this.addFood.Location = new System.Drawing.Point(162, 3);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(66, 48);
            this.addFood.TabIndex = 2;
            this.addFood.Text = "Thêm món";
            this.addFood.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.switchboxtotal);
            this.panel4.Controls.Add(this.switchbox);
            this.panel4.Controls.Add(this.saletotal);
            this.panel4.Controls.Add(this.sale);
            this.panel4.Controls.Add(this.thanhtoancheckout);
            this.panel4.Location = new System.Drawing.Point(268, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 64);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // switchboxtotal
            // 
            this.switchboxtotal.Location = new System.Drawing.Point(3, 38);
            this.switchboxtotal.Name = "switchboxtotal";
            this.switchboxtotal.Size = new System.Drawing.Size(72, 20);
            this.switchboxtotal.TabIndex = 4;
            // 
            // switchbox
            // 
            this.switchbox.Location = new System.Drawing.Point(3, 3);
            this.switchbox.Name = "switchbox";
            this.switchbox.Size = new System.Drawing.Size(72, 32);
            this.switchbox.TabIndex = 3;
            this.switchbox.Text = "Chuyển bàn";
            this.switchbox.UseVisualStyleBackColor = true;
            // 
            // saletotal
            // 
            this.saletotal.Location = new System.Drawing.Point(105, 41);
            this.saletotal.Name = "saletotal";
            this.saletotal.Size = new System.Drawing.Size(69, 20);
            this.saletotal.TabIndex = 2;
            this.saletotal.ValueChanged += new System.EventHandler(this.saletotal_ValueChanged);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(105, 3);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(69, 32);
            this.sale.TabIndex = 1;
            this.sale.Text = "Giảm giá";
            this.sale.UseVisualStyleBackColor = true;
            // 
            // thanhtoancheckout
            // 
            this.thanhtoancheckout.Location = new System.Drawing.Point(194, 6);
            this.thanhtoancheckout.Name = "thanhtoancheckout";
            this.thanhtoancheckout.Size = new System.Drawing.Size(75, 52);
            this.thanhtoancheckout.TabIndex = 0;
            this.thanhtoancheckout.Text = "Thanh toán";
            this.thanhtoancheckout.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // foodTableAdapter1
            // 
            this.foodTableAdapter1.ClearBeforeFill = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(263, 181);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // flpanel
            // 
            this.flpanel.AutoScroll = true;
            this.flpanel.Location = new System.Drawing.Point(3, 30);
            this.flpanel.Name = "flpanel";
            this.flpanel.Size = new System.Drawing.Size(262, 313);
            this.flpanel.TabIndex = 6;
            this.flpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flpanel_Paint);
            // 
            // ftablemanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 364);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ftablemanager";
            this.Text = "QuanLyCoffe";
            this.Load += new System.EventHandler(this.ftablemanager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totalfood)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.switchboxtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saletotal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown totalfood;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown switchboxtotal;
        private System.Windows.Forms.Button switchbox;
        private System.Windows.Forms.NumericUpDown saletotal;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button thanhtoancheckout;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private QuanLyCafeDataSetTableAdapters.FoodTableAdapter foodTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flpanel;
        private System.Windows.Forms.ListView listView2;
    }
}