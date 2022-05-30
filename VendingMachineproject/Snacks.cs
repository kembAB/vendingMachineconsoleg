using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineproject
{
    public class Snacks:Product
    {
        public bool islocalproduct { get; set; }
        public int calorie { get; set; }
     
        
        public Snacks(string name, string description, int price) : base(name, description, price)
        {
            islocalproduct = false;
            calorie = 33;
        }

        public Snacks(string name, string description, int price, bool localproduct, int calorieamount ) : base(name, description, price)
        {
            islocalproduct = localproduct;
            calorie = calorieamount;
        }

        public override string Examine()
        {
            return this.Name + ": price: " + this.Price + " product description : " + ProductDescription + "\n is produced locally : " + islocalproduct + "\n calorie amount : " + calorie;
        }

        public override string Use()
        {
            return "Eating snack " + this.Name + " crush  crush ..";
        }
    }
}

