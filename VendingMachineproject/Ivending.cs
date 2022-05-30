using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineproject
{
    interface Ivending
    {
        public bool Purchase(string id, out Product product);
        public Dictionary<string, Product> ShowAll();
        public bool InsertMoney(int money);
        public int[] EndTransaction();
    }
}
