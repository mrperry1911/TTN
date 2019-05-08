using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    class BillInfo
    {
        private static BillInfo instance;

        internal static BillInfo Instance
        {
            get { if (instance == null) instance = new BillInfo(); return BillInfo.instance; }
            private set { BillInfo.instance = value; }
        }
        public List<BillinfoDTO> GetListBillInfo(int id)
        {
            List<BillinfoDTO> listbillinfo = new List<BillinfoDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillInfo where idBill = " +  id);
            foreach (DataRow item in data.Rows)
            {
                BillinfoDTO info = new BillinfoDTO(item);
                listbillinfo.Add(info);
            }
            return listbillinfo;
        }
        public void InsertBillInfo(int idbill,int idfood,int count)
        {
            string query = "usp_InsertBillinfo @idbill , @idfood , @count";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idbill,idfood,count });

        }
    } 
}
