using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineproject
{
   
        public abstract class Product
        {
            public string Name { get; }

            public string ProductDescription { get; }
            public int Price { get; }

            public Product(string name, string description, int price)
            {
                this.Name = name;
                ProductDescription = description;
                this.Price = price;
            }

            public abstract string Examine();

            public abstract string Use();
        }
   
}
