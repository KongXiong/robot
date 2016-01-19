using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class AAA : PowerSource
    {
        string material = "Nickel Cadmium";
        string powerOutput = "Low";

        override public void turnOn()
        {
            Console.WriteLine("bzzzz..");
        }
    }
}
