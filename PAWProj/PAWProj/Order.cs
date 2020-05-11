using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWProj
{
    class Order
    {
        private string foodName;
        private string drinkName;
        private string address;
        private string code;

        Order() { }

        public Order(string foodName, string drinkName, string address, string code)
        {
            this.foodName = foodName;
            this.drinkName = drinkName;
            this.address = address;
            this.code = code;
        }


        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        public string DrinkName
        {
            get { return drinkName; }
            set { drinkName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public override string ToString()
        {
            string toPrint = null;
            toPrint += "Food :" + this.foodName + " , " + " Drink: "  + this.drinkName + ", Address: " + this.address + ", Code:  " + this.code;
            return toPrint;
        }

    }
}
