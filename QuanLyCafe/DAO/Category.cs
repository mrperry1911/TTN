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

    }
 }
 
