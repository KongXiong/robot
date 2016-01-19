using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class arcReactor : PowerSource
    {
        string material = "Vibranium";
        string powerOutput = "High";

        override public void turnOn()
        {
            Console.WriteLine("WHOM WHOM WHOM!!");
        }
    }
}
