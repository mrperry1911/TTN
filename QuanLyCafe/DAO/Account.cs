using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Account
    {
        private static Account instance;

        internal static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }

            private set { instance = value; }
        }
        public bool Login(string userName, string passWorrd)
        {
            string query = "usp_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWorrd });
            return result.Rows.Count > 0;
        }
    }
}
      



    
