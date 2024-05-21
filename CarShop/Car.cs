using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class Car
    {
        public Random Random = new Random();
        public string Model { get; private set; }
        public List<CarPart> Parts { get; private set; }

        public List<CarPart> NotWorking { get; private set; }


        public Car(string model)
        {
            Model = model;
            Parts = new List<CarPart>()
            {
                new("Engine", true),
                new("Breaks", true),
                new("Gear", true)
            };
            NotWorking = new List<CarPart>();
            WhatIsWrong();
            
        }


        public void WhatIsWrong()
        {
            
            int numOfProbs = Random.Next(1, Parts.Count);

            for (int i = 0; i < numOfProbs; i++)
            {
                int randomNum = Random.Next(0, Parts.Count);

                Parts[randomNum].SetFault();
                NotWorking.Add(Parts[randomNum]);
            }
            
        }

        public void FixFaults()
        {
            Console.WriteLine($"The {Model} has {NotWorking.Count} faults.");
            Console.WriteLine("The Mechanic is now fixing the car:");

            foreach (CarPart part in NotWorking )
            {
                Console.WriteLine($"{part.Type} is broken");
                part.FixFault();
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine($"{part.Type} is fixed");

            }
        }

    }
}
