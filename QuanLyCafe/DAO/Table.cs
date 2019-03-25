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
        public static int TableWidth = 50;
        public static int TableHeight = 50;
        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("   usp_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;


        }

    }
}
