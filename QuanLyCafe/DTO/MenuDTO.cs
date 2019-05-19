using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
   public class MenuDTO
    {
        public MenuDTO(string FoodName,int Count, float Price,float TotalPrice=0)
        {
            this.FoodName = this.FoodName;
            this.Count = this.Count;
            this.Price = this.Price;
            this.TotalPrice = this.TotalPrice;
        }
        public MenuDTO(DataRow row)
        {
            this.FoodName = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["Total"].ToString());
        }
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string FoodName
        {
            get
            {
                return foodName;
            }

            set
            {
                foodName = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public float TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }
    }
    
}
