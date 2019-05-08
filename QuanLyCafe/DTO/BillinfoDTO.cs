using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    class BillinfoDTO
    {
        public BillinfoDTO(int iD,int billID,int foodID,int count)
        {
            this.ID = iD;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;

        }
        public BillinfoDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
            this.Count = (int)row["count"];
        }
        private int iD;
        private int billID;
        private int foodID;
        private int count;
        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
    }
}
