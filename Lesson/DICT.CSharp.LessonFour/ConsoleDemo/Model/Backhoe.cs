using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    public class Backhoe : Car
    {
        public Backhoe()
        {
            Make = "Caterpillar";
            Year = 2013;
        }

        public override void Beep()
        {
            Console.WriteLine("Beep from AUV");
        }

        public void Dig()
        {
            Console.WriteLine("Diggity");
        }
    }
}
