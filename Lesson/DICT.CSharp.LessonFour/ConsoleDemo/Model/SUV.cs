﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    public class SUV : Car
    {
        public SUV()
        {
            Make = "BMW";
            Year = 2016;
        }

        public override void Beep()
        {
            Console.WriteLine("Beep from SUV");
        }
    }
}
