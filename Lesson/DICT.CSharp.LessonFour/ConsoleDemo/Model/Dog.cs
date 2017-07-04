using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public abstract void ShoutName();
    }


    public class Dog : Animal
    {
        public override void ShoutName()
        {
            Console.WriteLine("");
        }
    }

    public class Wolf : Dog
    {

    }

    public class Cat : Animal
    {
        public override void ShoutName()
        {
            Console.WriteLine("");
        }
    }

    public class Bat : Animal
    {
        public override void ShoutName()
        {
            Console.WriteLine("");
        }
    }
}
