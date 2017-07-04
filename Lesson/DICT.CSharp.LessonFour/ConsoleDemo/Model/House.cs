using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Model
{
    class House
    {
        public House()
        {
            
        }
        
        public House(int numberOfRooms, int numberOfBathrooms)
        {
            NumberOfRooms = numberOfRooms;
            NumberOfBathrooms = numberOfBathrooms;
        }


        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }

        private string _build;
        public string Build
        {
            get {
                return _build;
            }
            set
            {
                _build = "Made in:" + value;
            }
        }

        public void Knock()
        {
            Console.WriteLine("*knock on door*");
        }


        void PlaceMail(int howMany)
        {
            Console.WriteLine("Mail Received: " + howMany);
        }

        void PlaceMail(string whatMail)
        {
            Console.WriteLine("You got: " + whatMail);
        }

        ~House()
        {
            Console.WriteLine("Deleted");
        }
    }
}
