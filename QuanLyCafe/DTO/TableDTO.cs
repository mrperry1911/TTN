using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class TableDTO
    {
        private string name;
        private int iD;
        private string status;
        public TableDTO(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public TableDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
      
        internal string Status { get => status; set => status = value; }
        internal string Name { get => name; set => name = value; }
        internal int ID { get => iD; set => iD = value; }
    }
}
