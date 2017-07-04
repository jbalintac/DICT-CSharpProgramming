using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{


    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public virtual void Beep()
        {
            Console.Write("Beep beep");
        }
    }
}
