using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerGmap.Model
{

    /// <summary>
    /// This class represents an earthquake
    /// </summary>
    public class Earthquake
    {
        /// <summary>
        /// The moment the earthquake ocurred, measured in Unix timestamp.
        /// </summary>
        public long Time { get; set; }
        /// <summary>
        /// The place where the earthquake ocurred.
        /// </summary>
        public string Place { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Magnitude { get; set; }
        public string Url { get; set; }

        public Earthquake(string place, long time, double longitude, double latitude, double magnitude, string url)
        {
            this.Place = place;
            this.Time = time;
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Magnitude = magnitude;
            this.Url = url;
            GetHour();
        }

        public override string ToString()
        {
            return "Mag: "+Magnitude+" - "+Place;
        }

        public string GetDate()
        {
            var localDateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(Time).DateTime.ToLocalTime();            
            return localDateTimeOffset.ToString("MMM dd yyyy");

        }

        public string GetHour()
        {
            var localDateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(Time).DateTime.ToLocalTime();
            return localDateTimeOffset.ToString("hh:mm tt");
        }


    }
}
