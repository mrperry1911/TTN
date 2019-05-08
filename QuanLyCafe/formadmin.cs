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
    public partial class tbfoodcategory : Form
    {
        BindingSource foodList = new BindingSource();
        public tbfoodcategory()
        {
            dtgvFood.DataSource = foodList;
            if (dtgvFood.DataSource == null)
                return;
            InitializeComponent();
            LoadFoodList();
            LoadListByDate(dtpkleft.Value, dtpkright.Value);
            LoadDateTimePickerBill();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbfoodcategory);
        }
        #region Method
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkleft.Value = new DateTime(today.Year, today.Month, 1);
            dtpkright.Value = dtpkleft.Value.AddMonths(1).AddDays(-1);
        
        }
        void LoadFoodList()
        {
            foodList.DataSource = Food.Instance.GetListFood();
        }
        void LoadListByDate(DateTime checkIn,DateTime checkOut)
        {
            dtgvbill.DataSource=Bill.Instance.GetBillListByDate(checkIn, checkOut);

        }
        void AddFoodBinding()
        {
            
            tbfoodname.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            tbfoodid.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            nmprice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price"));
    
        }
        void LoadCategoryIntoCombobox(ComboBox box)
        {
            box.DataSource = Category.Instance.GetListCategory();
            box.DisplayMember = "Name";
        }
        #endregion
        #region event
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fthongke_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpkleft.Value, dtpkright.Value);
        }
        #endregion

        private void dtgvbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
