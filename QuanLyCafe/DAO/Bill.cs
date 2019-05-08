using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    class Bill
    {
        private static Bill instance;//Crl+R+E

        internal static Bill Instance
        {
            get { if (instance == null) instance = new Bill(); return Bill.instance; }
            private set { Bill.instance = value; }
        }
        
        //Thanh Cong bill ID
        //ThatBai : -1
        public int GetUncheckBillIDByTableID(int id)
        {
           DataTable data = DataProvider.Instance.ExecuteQuery(" select * from dbo.Bill where idTable = " + id + " and  status = 0");
            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("usp_InsertBill @idtable",new object[] {id});

        }
        public DataTable GetBillListByDate(DateTime checkIn,DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public void CheckOut(int id, int discount,float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int GetMaxBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(id) from dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
           
    }
}
