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
           var arrays = new int[] { 1,2 };

            try
            {
                arrays[1] = arrays[7] + 1;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Doing something");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Doing something");
            }
            catch
            {
                Console.WriteLine("Doing something");
            }
            finally
            {

                Console.WriteLine("Doing something");
            }


            Console.WriteLine("Doing something");

        }
    }


    /*
 var cars = new List<Car>
            {
                new Car { Make = "Base Car", Year = 2015},
                new SUV { Year = 2017},
                new Backhoe { Year = 2016},
                new Coupe { Year = 2018},
            };


            var carsBefore2016 = from car in cars
                                 where car.Make == "" && car.Year > 1
                                 select new
                                 {
                                     Make = car.Make,
                                     Style = "Generic",
                                     RemainingYears = 2020 - car.Year
                                 };

            var carsBefore2016v2 =
                cars.Where(c => c.Make == "" && c.Year > 1)
                    .Select(c => new {
                                         Make = c.Make,
                                         Style = "Generic",
                                         RemainingYears = 2020 - c.Year
                                     });


            foreach (var item in carsBefore2016)
            {
                Console.WriteLine(item.Make + " " + item.RemainingYears);
            }
            
     */
}
