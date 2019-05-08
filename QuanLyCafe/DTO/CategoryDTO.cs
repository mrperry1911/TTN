using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class CategoryDTO
    {
        private string name;
        private int iD;
        public CategoryDTO(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public CategoryDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name =row["name"].ToString();
        }


        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
