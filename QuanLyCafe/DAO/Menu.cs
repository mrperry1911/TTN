using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
   public class Menu
    {
        private static Menu instance;

        internal static Menu Instance
        {
            get { if (instance == null) instance = new Menu(); return Menu.instance; }
            private set { instance = value; }
        }
            public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> listmenu = new List<MenuDTO>();
            string query = " select b.name,b.price,a.count,b.price*a.count as Total,e.id from BillInfo a join Food b on a.idFood = b.id join Bill c on c.id = a.idBill and c.status=0 join TableFood e on e.id = c.idTable and c.idTable = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)

            {
                MenuDTO menu = new MenuDTO(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
        }
    }

