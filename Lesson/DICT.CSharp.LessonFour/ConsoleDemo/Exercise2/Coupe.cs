using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Exercise2
{
    public class Coupe : Car
    {
        public override void Beep()
        {
            Console.WriteLine("Beeping from Coupe");
        }
    }
}
