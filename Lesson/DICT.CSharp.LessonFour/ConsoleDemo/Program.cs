using ConsoleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car { Make = "Base Car", Year = 2015},
                new SUV { Year = 2017},
                new Backhoe { Year = 2016},
                new Coupe { Year = 2018},
            };


            var carsBefore2016 = from car in cars
                                 select new
                                 {
                                     Make = car.Make,
                                     Style = "Generic",
                                     RemainingYears = 2020 -car.Year
                                 };

            foreach (var item in carsBefore2016)
            {
                Console.WriteLine(item.Make + " " + item.RemainingYears);
            }
            
        }
    }   
}
