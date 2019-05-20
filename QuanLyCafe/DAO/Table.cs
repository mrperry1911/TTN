using QuanLyCafe.DTO;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Table
    {
        private static Table instance;
        internal static Table Instance
        {
            get { if (instance == null) instance = new Table(); return Table.instance; }
            private set { Table.instance = value; }
        }
        public static int TableWidth = 70;
        public static int TableHeight = 70;
        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetTableList");
            foreach (DataRow item in data.Rows)//Duyệt từng dòng (DataRow) trong DataTable
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public bool InsertTable(string name,string status)
        {
            string query = string.Format("INSERT INTO dbo.TableFood(name, status )VALUES  ( N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(string name, string status,int id)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}', status = N'{1}' WHERE id = {2}", name,status,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            //BillInfo.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete TableFood where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public void SwitchTable(int id1 , int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTable2", new object[] { id1, id2 });
        }


    }
}
        