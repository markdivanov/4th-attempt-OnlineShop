using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Product()
        {
            Name = "nothing yet";
            Amount = 0;
        }
        public Product(string n, int a)
        {
            Name = n;
            Amount = a;
        }

    }
}
