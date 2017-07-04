using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Exercise2
{
    public class AUV : Car
    {
        public override void Beep()
        {
            Console.WriteLine("Beeping from AUV");
        }
    }
}
