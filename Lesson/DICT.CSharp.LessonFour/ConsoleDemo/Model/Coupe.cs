using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    public class Coupe : Car
    {
        public Coupe()
        {
            Make = "Porcshe";
            Year = 2015;
        }

        public override void Beep()
        {
            Console.WriteLine("Beep from Coupe");
        }
    }
}
