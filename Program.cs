using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstact
{ abstract class vehicle
    {
        public int wheeels = 4;
    }
    class Corsa : vehicle 
    {
        public int sparewheels = 1;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Corsa car2 = new Corsa();
            Console.WriteLine(car2.sparewheels);
            Console.ReadLine();
        }
    }
}
