using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class head
    {
        int eyes = 2;
        string brain = "cpu";

        public void scan()
        {
            Console.WriteLine("beeb... beeb... target aquired.");
        }

        public void transmit()
        {
            Console.WriteLine("transmit data...complete.");
        }
    }
}
