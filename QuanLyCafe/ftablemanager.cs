using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class ftablemanager : Form
    {
        private AccountDTO loginAccount;

        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public ftablemanager(AccountDTO acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComBoBoxTable(cbswitch);
            
        }
        #region Method  
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
       public void LoadCategory()
        {
            List<CategoryDTO> listCategory = Category.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
            

        }
        void LoadFoodListByCategory(int id)
        {
            List<FoodDTO> listFood = Food.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";

        }
        void LoadTable()
        {
            flpanel.Controls.Clear();   
            List<TableDTO> tablelist = Table.Instance.LoadTableList();
            foreach (TableDTO item in tablelist)
            {
                Button btm = new Button() { Width = Table.TableWidth, Height = Table.TableHeight };
                
                btm.Text = item.Name + Environment.NewLine + item.Status;
                btm.Click += btm_Click;
                btm.Tag = item;
                switch(item.Status)
                {
                    case "Trống":
                        btm.BackColor = Color.Aqua;
                        break;
                    default:
                        btm.BackColor = Color.Red;
                        break;
                }
                flpanel.Controls.Add(btm);

            }
        }
        void ShowBill(int id)
        {
            lvbill.Items.Clear();
            List<MenuDTO> listBillInfo = DAO.Menu.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (MenuDTO item in listBillInfo)
            {   
                ListViewItem lvitem = new ListViewItem(item.FoodName.ToString());
                lvitem.SubItems.Add(item.Count.ToString());
                lvitem.SubItems.Add(item.Price.ToString());
                lvitem.SubItems.Add(item.TotalPrice.ToString());
                
                totalPrice += item.TotalPrice;
                lvbill.Items.Add(lvitem);

            }
            CultureInfo culture = new CultureInfo("vi-VN");
            tbtotal.Text = totalPrice.ToString("c",culture  );
            
        }
        void LoadComBoBoxTable(ComboBox box)
        {
            box.DataSource = Table.Instance.LoadTableList();
            box.DisplayMember = "Name";
        }

        #endregion
        #region event
        void btm_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).ID;
            lvbill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }


        private void ftablemanager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCafeDataSet.FoodCategory' table. You can move, or remove it, as needed.
            //this.foodCategoryTableAdapter.Fill(this.quanLyCafeDataSet.FoodCategory);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saletotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faccountprofile f = new faccountprofile(loginAccount);
            f.ShowDialog() ;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgvcateogory f = new dtgvcateogory();
            f.LoginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategory((cbCategory.SelectedItem as CategoryDTO).ID);
            if (lvbill.Tag != null)
                ShowBill((lvbill.Tag as TableDTO).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategory((cbCategory.SelectedItem as CategoryDTO).ID);
            if (lvbill.Tag != null)
                ShowBill((lvbill.Tag as TableDTO).ID);
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategory((cbCategory.SelectedItem as CategoryDTO).ID);
            if (lvbill.Tag != null)
                ShowBill((lvbill.Tag as TableDTO).ID);
        }


        private void flowpaneltable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvbill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void thanhtoancheckout_Click(object sender, EventArgs e)
        {
            TableDTO table = lvbill.Tag as TableDTO;
            int idBill = Bill.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmdiscount.Value;
            double totalPrice = Convert.ToDouble(tbtotal.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
               if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}",table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    Bill.Instance.CheckOut(idBill, discount,(float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {

        }  

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox box = (sender as ComboBox);

            if (box.SelectedItem as CategoryDTO == null)
                return;

            CategoryDTO selected = box.SelectedItem as CategoryDTO;
            id = selected.ID;
            LoadFoodListByCategory(id);

        }

        private void addFood_Click(object sender, EventArgs e)
        {
            if (lvbill.Tag as TableDTO == null)
                return;

            TableDTO table = lvbill.Tag as TableDTO;
            

            int idBill = Bill.Instance.GetUncheckBillIDByTableID(table.ID);
            
            int foodID = (cbFood.SelectedItem as FoodDTO).ID;
            int count = (int)nmcount.Value;

            if(idBill==-1)
            {
                Bill.Instance.InsertBill(table.ID);
                BillInfo.Instance.InsertBillInfo(Bill.Instance.GetMaxBill(),foodID,count);
            }
            else
            {
                BillInfo.Instance.InsertBillInfo(idBill, foodID, count);
            }
            
            ShowBill(table.ID);
            LoadTable();
        }

        private void sale_Click(object sender, EventArgs e)
        {
           
        }

        private void switchbox_Click(object sender, EventArgs e)
        {
            
            int id1 = (lvbill.Tag as TableDTO).ID;
            int id2 = (cbswitch.SelectedItem as TableDTO).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển  {0} qua  {1}", (lvbill.Tag as TableDTO).Name, (cbswitch.SelectedItem as TableDTO).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Table.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
