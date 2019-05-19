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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvbill = new System.Windows.Forms.ListView();
            this.NameFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COUNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmcount = new System.Windows.Forms.NumericUpDown();
            this.addFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbswitch = new System.Windows.Forms.ComboBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.switchbox = new System.Windows.Forms.Button();
            this.nmdiscount = new System.Windows.Forms.NumericUpDown();
            this.sale = new System.Windows.Forms.Button();
            this.thanhtoancheckout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyCafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCafeDataSet = new QuanLyCafe.QuanLyCafeDataSet();
            this.foodTableAdapter1 = new QuanLyCafe.QuanLyCafeDataSetTableAdapters.FoodTableAdapter();
            this.foodCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodCategoryTableAdapter = new QuanLyCafe.QuanLyCafeDataSetTableAdapters.FoodCategoryTableAdapter();
            this.foodCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdiscount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            // flpanel
            // 
            this.flpanel.AutoScroll = true;
            this.flpanel.Location = new System.Drawing.Point(3, 30);
            this.flpanel.Name = "flpanel";
            this.flpanel.Size = new System.Drawing.Size(262, 310);
            this.flpanel.TabIndex = 6;
            this.flpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flpanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvbill);
            this.panel3.Location = new System.Drawing.Point(268, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 187);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lvbill
            // 
            this.lvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFood,
            this.COUNT,
            this.Price,
            this.Total});
            this.lvbill.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvbill.Location = new System.Drawing.Point(3, 3);
            this.lvbill.Name = "lvbill";
            this.lvbill.Size = new System.Drawing.Size(269, 181);
            this.lvbill.TabIndex = 0;
            this.lvbill.UseCompatibleStateImageBehavior = false;
            this.lvbill.View = System.Windows.Forms.View.Details;
            this.lvbill.SelectedIndexChanged += new System.EventHandler(this.lvbill_SelectedIndexChanged);
            // 
            // NameFood
            // 
            this.NameFood.Text = "Tên món";
            this.NameFood.Width = 67;
            // 
            // COUNT
            // 
            this.COUNT.Text = "Số lượng";
            this.COUNT.Width = 67;
            // 
            // Price
            // 
            this.Price.Text = "Giá";
            this.Price.Width = 48;
            // 
            // Total
            // 
            this.Total.Text = "Thành tiền";
            this.Total.Width = 85;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nmcount);
            this.panel5.Controls.Add(this.addFood);
            this.panel5.Controls.Add(this.cbFood);
            this.panel5.Controls.Add(this.cbCategory);
            this.panel5.Location = new System.Drawing.Point(268, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 53);
            this.panel5.TabIndex = 4;
            // 
            // nmcount
            // 
            this.nmcount.Location = new System.Drawing.Point(228, 19);
            this.nmcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmcount.Name = "nmcount";
            this.nmcount.Size = new System.Drawing.Size(44, 20);
            this.nmcount.TabIndex = 3;
            this.nmcount.Value = new decimal(new int[] {
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
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 30);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(158, 21);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(158, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbswitch);
            this.panel4.Controls.Add(this.tbtotal);
            this.panel4.Controls.Add(this.switchbox);
            this.panel4.Controls.Add(this.nmdiscount);
            this.panel4.Controls.Add(this.sale);
            this.panel4.Controls.Add(this.thanhtoancheckout);
            this.panel4.Location = new System.Drawing.Point(268, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 64);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cbswitch
            // 
            this.cbswitch.FormattingEnabled = true;
            this.cbswitch.Location = new System.Drawing.Point(3, 40);
            this.cbswitch.Name = "cbswitch";
            this.cbswitch.Size = new System.Drawing.Size(75, 21);
            this.cbswitch.TabIndex = 6;
            this.cbswitch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(144, 26);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(68, 20);
            this.tbtotal.TabIndex = 5;
            this.tbtotal.Text = "0";
            this.tbtotal.TextChanged += new System.EventHandler(this.tbtotal_TextChanged);
            // 
            // switchbox
            // 
            this.switchbox.Location = new System.Drawing.Point(3, 3);
            this.switchbox.Name = "switchbox";
            this.switchbox.Size = new System.Drawing.Size(75, 32);
            this.switchbox.TabIndex = 3;
            this.switchbox.Text = "Chuyển bàn";
            this.switchbox.UseVisualStyleBackColor = true;
            this.switchbox.Click += new System.EventHandler(this.switchbox_Click);
            // 
            // nmdiscount
            // 
            this.nmdiscount.Location = new System.Drawing.Point(81, 41);
            this.nmdiscount.Name = "nmdiscount";
            this.nmdiscount.Size = new System.Drawing.Size(57, 20);
            this.nmdiscount.TabIndex = 2;
            this.nmdiscount.ValueChanged += new System.EventHandler(this.saletotal_ValueChanged);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(81, 3);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(57, 32);
            this.sale.TabIndex = 1;
            this.sale.Text = "Giảm giá";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // thanhtoancheckout
            // 
            this.thanhtoancheckout.Location = new System.Drawing.Point(218, 13);
            this.thanhtoancheckout.Name = "thanhtoancheckout";
            this.thanhtoancheckout.Size = new System.Drawing.Size(51, 45);
            this.thanhtoancheckout.TabIndex = 0;
            this.thanhtoancheckout.Text = "Thanh toán";
            this.thanhtoancheckout.UseVisualStyleBackColor = true;
            this.thanhtoancheckout.Click += new System.EventHandler(this.thanhtoancheckout_Click);
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
            // quanLyCafeDataSetBindingSource
            // 
            this.quanLyCafeDataSetBindingSource.DataSource = this.quanLyCafeDataSet;
            this.quanLyCafeDataSetBindingSource.Position = 0;
            // 
            // quanLyCafeDataSet
            // 
            this.quanLyCafeDataSet.DataSetName = "QuanLyCafeDataSet";
            this.quanLyCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodTableAdapter1
            // 
            this.foodTableAdapter1.ClearBeforeFill = true;
            // 
            // foodCategoryBindingSource
            // 
            this.foodCategoryBindingSource.DataMember = "FoodCategory";
            this.foodCategoryBindingSource.DataSource = this.quanLyCafeDataSetBindingSource;
            // 
            // foodCategoryTableAdapter
            // 
            this.foodCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // foodCategoryBindingSource1
            // 
            this.foodCategoryBindingSource1.DataMember = "FoodCategory";
            this.foodCategoryBindingSource1.DataSource = this.quanLyCafeDataSetBindingSource;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.nmcount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdiscount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nmcount;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button switchbox;
        private System.Windows.Forms.NumericUpDown nmdiscount;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button thanhtoancheckout;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private QuanLyCafeDataSetTableAdapters.FoodTableAdapter foodTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flpanel;
        private System.Windows.Forms.ListView lvbill;
        private System.Windows.Forms.ColumnHeader NameFood;
        private System.Windows.Forms.ColumnHeader COUNT;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.BindingSource quanLyCafeDataSetBindingSource;
        private QuanLyCafeDataSet quanLyCafeDataSet;
        private System.Windows.Forms.BindingSource foodCategoryBindingSource;
        private QuanLyCafeDataSetTableAdapters.FoodCategoryTableAdapter foodCategoryTableAdapter;
        private System.Windows.Forms.BindingSource foodCategoryBindingSource1;
        private System.Windows.Forms.ComboBox cbswitch;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}