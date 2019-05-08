using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class AccountDTO
    {
        public AccountDTO(string displayName,string userName, int type,string passWord = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = passWord;
        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }
            
           
        private int type;
        private string password;
        private string displayName;
        private string userName;
        public int Type { get => type; set => type = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
