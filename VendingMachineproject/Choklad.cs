using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineproject
{
   public   class Choklad:Product
   {

        public bool hasmilk { get; set; }
        public int size  { get; set; }


        public Choklad(string name, string description, int price) : base(name, description, price)
        {
            hasmilk = false;
            size = 33;
        }

        public Choklad(string name, string description, int price, bool hasmilkinit, int sizeofchocolate) : base(name, description, price)
        {
            hasmilk = hasmilkinit;
            size = sizeofchocolate;
        }

        public override string Examine()
        {
            return this.Name + ": price: " + this.Price + " product description : " + ProductDescription + "\n does milk exist : " + hasmilk + "\n size of chocholat : " + size;
        }

        public override string Use()
        {
            return "Eating chocolate " + this.Name + " yum yum  ";
        }
    }
}
