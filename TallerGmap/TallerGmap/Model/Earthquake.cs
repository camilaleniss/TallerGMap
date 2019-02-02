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
        public string Place { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Magnitude { get; set; }
        public string Url { get; set; }

        public Earthquake(string place, long time, double longitude, double latitude, double magnitude, string url)
        {
            this.Time = time;
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Magnitude = magnitude;
            this.Url = url;
        }




    }
}
