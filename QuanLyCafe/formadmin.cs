using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class dtgvcateogory : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();

        public dtgvcateogory()
        {

           
            InitializeComponent();
            dtgvFood.DataSource = foodList;
            dtgvcategoryFood.DataSource = categoryList;
            dtgvtable.DataSource = tableList;
            LoadFoodList();
            LoadListByDate(dtpkleft.Value, dtpkright.Value);
            LoadDateTimePickerBill();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbfoodcategory);
            LoadCategoryList();
            AddCategoryBinding();
            LoadTableList();
            AddTableBinding();

        }
        #region Method
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkleft.Value = new DateTime(today.Year, today.Month, 1);
            dtpkright.Value = dtpkleft.Value.AddMonths(1).AddDays(-1);
        
        }
        void LoadCategoryList()
        {
            categoryList.DataSource = Category.Instance.GetListCategory();
        }
        void LoadFoodList()
        {
            foodList.DataSource = Food.Instance.GetListFood();
        }
        void LoadTableList()
        {
            tableList.DataSource = Table.Instance.LoadTableList();
        }
        void LoadListByDate(DateTime checkIn,DateTime checkOut)
        {
            dtgvbill.DataSource=Bill.Instance.GetBillListByDate(checkIn, checkOut);

        }
        void AddFoodBinding()
        {
            
            tbfoodname.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tbfoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmprice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
    
        }

        void AddCategoryBinding()
        {
            tbcategoryID.DataBindings.Add(new Binding("Text", dtgvcategoryFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbcategoryName.DataBindings.Add(new Binding("Text", dtgvcategoryFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void AddTableBinding()
        {
            tbtableid.DataBindings.Add(new Binding("Text", dtgvtable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbtablename.DataBindings.Add(new Binding("Text",dtgvtable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tbstatus.DataBindings.Add(new Binding("Text", dtgvtable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }


        void LoadCategoryIntoCombobox(ComboBox box)
        {
            box.DataSource = Category.Instance.GetListCategory();
            box.DisplayMember = "Name";
        }
        void AddCategory(string name)
        {
            if (Category.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm loại món thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm loại món");
            }
            LoadCategoryList();
        }
        void UpdateCategory(string name,int id)
        {
            if(Category.Instance.UpdateCategory(name,id))
            {
                MessageBox.Show("Sửa loại món thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa loại món");
            }
            LoadCategoryList();
        }
        void DeleteCategory(int id)
        {
            if(Category.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa loại món thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa loại món");
            }
            LoadCategoryList();
        }
           
        #endregion
        #region event
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fedit_Click(object sender, EventArgs e)
        {
            string name = tbfoodname.Text;
            int categoryID = (cbfoodcategory.SelectedItem as CategoryDTO).ID;
            float price = (float)nmprice.Value;
            int id = Convert.ToInt32(tbfoodID.Text);

            if (Food.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodList();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formadmin_Load(object sender, EventArgs e)
        {

        }


        private void fthongke_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpkleft.Value, dtpkright.Value);
        }
        #endregion

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbfoodID_TextChanged(object sender, EventArgs e) //categoryName
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                CategoryDTO cateogory = Category.Instance.GetCategoryByID(id);

                cbfoodcategory.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (CategoryDTO item in cbfoodcategory.Items)
                {
                    if (item.ID == cateogory.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }


                cbfoodcategory.SelectedIndex = index;
            }
        }
       



        private void expandableSplitter2_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {

        }

        private void fadd_Click(object sender, EventArgs e)
        {
            string name = tbfoodname.Text;
            int categoryID = (cbfoodcategory.SelectedItem as CategoryDTO).ID;
            float price = (float)nmprice.Value;

            if (Food.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadFoodList();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

 
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void Fdelete1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbfoodID.Text);

            if (Food.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadFoodList();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());  
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

     

        //private event EventHandler insertCategory;
        //public event EventHandler InsertCategory
        //{
        //    add { insertCategory += value; }
        //    remove { insertCategory -= value; }
        //}

        //private event EventHandler deleteCategory;
        //public event EventHandler DeleteCategory
        //{
        //    add { deleteCategory += value; }
        //    remove { deleteCategory -= value; }
        //}

        //private event EventHandler updateCategory;
        //public event EventHandler UpdateCategory
        //{
        //    add { updateCategory += value; }
        //    remove { updateCategory -= value; }
        //}

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbcategory2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fwatchver2_Click(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void expandableSplitter1_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {

        }

        private void expandableSplitter2_ExpandedChanged_1(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {

        }

        private void dtgvcategoryFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void faddver2_Click_1(object sender, EventArgs e)
        {
            string name = tbcategoryName.Text;
            AddCategory(name);
        }

        private void expandableSplitter1_ExpandedChanged_1(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {

        }

        private void feditver2_Click(object sender, EventArgs e)
        {
            string name = tbcategoryName.Text;
            int id = Convert.ToInt32(tbcategoryID.Text);
            UpdateCategory(name,id);
        }

        private void fdeletever2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbcategoryID.Text);
            DeleteCategory(id);

        }

        private void tbstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private void faddver3_Click(object sender, EventArgs e)
        {
            string name = tbfoodname.Text;
            //int ID = int.Parse(tbtableid.Text);
            string status = tbstatus.Text;

            if (Table.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTableList();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }
    }
}
