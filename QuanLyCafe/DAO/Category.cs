using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    class Category
    {
        private static Category instance;

        internal static Category Instance
        {
            get { if (instance == null) instance = new Category(); return Category.instance; }
            private set { instance = value; }
        }
        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                list.Add(category);
            }
            return list;
        }
        public CategoryDTO GetCategoryByID(int id)
        {
            CategoryDTO category = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new CategoryDTO(item);
                return category;
            }

            return category;
        }
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT INTO dbo.FoodCategory (name)VALUES( N'{0}')",name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(string name,int id)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}'WHERE id = {1}", name,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            ////BillInfo.Instance.DeleteBillInfoByFoodID(idFood);
            Food.Instance.DeleteFoodByCategoryID(id);
            string query = string.Format("Delete FoodCategory where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
 }
 
