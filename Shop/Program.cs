using OnlineStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = " ";
            int Amount = 0;
            List<Product> prod = new List<Product>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("What's the product's name?");
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("What's the product's amount?");
                Amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Product Name is " + Name + " and amount of " + Amount);
            }

            while (true)
            {
                if (Amount < 30)
                    Amount += 300;
                Console.WriteLine("Product " + Name + " after restocking is " + Amount);
                if (Amount > 20)
                    Amount -= 20;
                Console.WriteLine("Product " + Name + " after buying is " + Amount);
                if (Amount < 0)
                    throw new NotImplementedException("Cant buy more. Need restocking");
                Thread.Sleep(1000);//wait 1 sec between cycle cuz it too fast
            }
            Console.ReadLine();
        }
    }
}