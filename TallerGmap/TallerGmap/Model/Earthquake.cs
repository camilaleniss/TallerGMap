using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerGmap.Model
{
    public class Earthquake
    {
        public long Time { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public double Magnitude { get; set; }

        public Earthquake(long time, int longitude, int latitude, double magnitude)
        {
            this.Time = time;
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Magnitude = magnitude;
        }




    }
}
