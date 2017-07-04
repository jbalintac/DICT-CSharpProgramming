using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Exercise2
{
    public abstract class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public abstract void Beep();
    }
}
