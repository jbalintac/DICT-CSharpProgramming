using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    public class RepairShop
    {
        public void RepairCar<T>(T car) where T : Car
        {
            Console.WriteLine("Repairing: " + car.Make);
        }

        //public void RepairCar(Car car) 
        //{
        //    Console.WriteLine("Repairing: " + car.Make);
        //}

    }
}
