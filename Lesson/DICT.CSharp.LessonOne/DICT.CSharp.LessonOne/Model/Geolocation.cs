using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICT.CSharp.LessonOne.Model
{
    struct Geolocation
    {
        public Geolocation(int lat, int @long)
        {
            Lat = lat;
            Long = @long;
        }

        public int Lat { get; set; }
        public int Long { get; set; }
    }
}
