using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineproject
{
   public  class VendingMachine:Ivending
    {
        private int MoneyPool;
        public int Money { get { return MoneyPool; } }
        public readonly int[] MoneyDenominations;
        private readonly Dictionary<string, Product> storage = new Dictionary<string, Product>();

        public VendingMachine()
        {
            MoneyDenominations = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            MoneyPool = 0;
            Inventory();
        }
        public int[] EndTransaction()
        {
            int[] moneyBack = MakeChange(MoneyPool);
            MoneyPool = 0;

            return moneyBack;
        }

        public bool InsertMoney(int insertedMoney)
        {
            for (int i = 0; i < MoneyDenominations.Length; i++)
            {
                if (insertedMoney == MoneyDenominations[i])
                {
                    MoneyPool += insertedMoney;
                    return true;
                }
            }
            return false;
        }
        public void Inventory()
        {
         //Snack Invory
            Snacks Cheezdoodles = new Snacks("Cheezdoodles","A type of snack cheez",23,true,123);
            storage.Add("1", Cheezdoodles);
                Snacks EsterellaChips = new Snacks("EsterellaChips", "A type of snack Esterella", 12, false, 240);
            storage.Add("2", EsterellaChips);
            Snacks OnionFlavorring = new Snacks("OnionFlavorring ", "A type of snack OnionFlavorring ", 14, false, 150);
            storage.Add("3", OnionFlavorring);
            //soft drink inventorty
       
            SoftDrinks Cola = new SoftDrinks("Cola","The famous soft drink cola",12,true,12);
            storage.Add("21", Cola);
            SoftDrinks Fanta = new SoftDrinks("Fanta", "The famous soft drink Fanta", 12, true, 12);
            storage.Add("22", Fanta);
            SoftDrinks Sprite = new SoftDrinks("Sprite", "The famous soft drink Sprite", 12, true, 12);
            storage.Add("23", Sprite);
            //chocholate Inventory

           
            Choklad Twix = new Choklad("twix","the famous chocolate twix ",15,true,8);
            storage.Add("31", Twix);
            Choklad chokladmerci = new Choklad("merci", "the famous chocolate merci", 16, false, 3);
            storage.Add("32", chokladmerci); 
            Choklad marbou = new Choklad("marabout","famous chocolate marabou",22,true,9);
            storage.Add("33", marbou);

        }
        public bool Purchase(string id, out Product product)
        {
            product = null;

            if (this.storage.ContainsKey(id))
            {
                if (this.storage[id].Price <= this.MoneyPool)
                {
                    product = this.storage[id];
                    MoneyPool -= this.storage[id].Price;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool Purchase(string id, out Product product, out string message)
        {
            product = null;
            message = null;

            if (this.storage.ContainsKey(id))
            {
                if (this.storage[id].Price <= this.MoneyPool)
                {
                    product = this.storage[id];
                    MoneyPool -= this.storage[id].Price;
                    return true;
                }
                else
                {
                    message = "Not enough money to buy product!";
                    return false;
                }
            }
            else
            {
                message = "No product found with id: " + id;
                return false;
            }
        }

        public Dictionary<string, Product> ShowAll()
        {
            Dictionary<string, Product> copyStorage = new Dictionary<string, Product>(this.storage);

            return copyStorage;
        }

        public int[] MakeChange(int target)
        {
            int size = this.MoneyDenominations.Length;
            int[] counts = new int[size];
            Array.Fill(counts, 0);

            int remainder = target;
            int bill = this.MoneyDenominations.Length - 1;
            while (remainder > 0)
            {
                counts[bill] = remainder / this.MoneyDenominations[bill];
                remainder -= counts[bill] * this.MoneyDenominations[bill];
                bill--;
            }

            return counts;
        }
    }
}

