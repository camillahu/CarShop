using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class Shop
    {
        public List<Car> Cars { get; private set; }

        public Shop()
        {
            Cars = new List<Car>()
            {
                new ("Toyota"),
                new ("Volvo"),
                new("Subaru")
            };
        }

        public void RunShop(Car carToFix)
        {
            Console.WriteLine("Welcome to the shop!");
            Thread.Sleep(2000);
            Console.WriteLine($"{Cars[0].Model} is driving into the shop");
            carToFix.FixFaults();
            Console.WriteLine();
            Console.WriteLine("Thank you for visiting the shop! Welcome back!");
            Console.WriteLine("******************************************************");
        }
    }
    
}
