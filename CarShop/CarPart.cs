using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class CarPart
    {
        public string Type { get; private set;}
        public bool IsWorking { get; private set; }

        public CarPart(string type, bool isWorking)
        {
            Type = type;
            IsWorking = isWorking;
        }

        public void SetFault()
        {
            IsWorking = false;
        }

        public void FixFault()
        {
            IsWorking = true;
        }
    }
}
