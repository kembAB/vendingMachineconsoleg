using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineproject
{
    public class SoftDrinks:Product
    {

        public bool sugerfree { get; set; }
        public int mililiter { get; set; }


        public SoftDrinks(string name, string description, int price) : base(name, description, price)
        {
            sugerfree = false;
            mililiter = 33;
        }

        public SoftDrinks(string name, string description, int price, bool utansocker, int amount) : base(name, description, price)
        {
            sugerfree = utansocker;
            mililiter = amount;
        }

        public override string Examine()
        {
            return this.Name + ": price: " + this.Price + " product description : " + ProductDescription + "\n is suger free? : " + sugerfree + "\n amount : " + mililiter;
        }

        public override string Use()
        {
            return "Drinking soft drink   " + this.Name + " sip   sip ..";
        }
    }
}
