using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Exercise2
{
    public class Backhoe : AUV
    {
        public Backhoe()
        {
            Make = "Caterpillar";
            Year = 2016;
        }


        public void Dig()
        {

            Console.WriteLine("Beeping from Backhoe");
        }

    }
}
