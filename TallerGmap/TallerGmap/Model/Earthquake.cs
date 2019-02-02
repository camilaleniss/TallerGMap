using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerGmap.Model
{

    /// <summary>
    /// This class represents an Earthquake
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
        /// <summary>
        /// The coordinate of the earthquake's longitude
        /// </summary>
        public double Longitude { get; set; }
        /// <summary>
        /// The coordinate of the earthquake's latitude
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// The magnitude of the earthquake
        /// </summary>
        public double Magnitude { get; set; }
        /// <summary>
        /// The url of the web site where you can find more information about the earthquake
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///  Constructor method of the Earthquake class. <para/>
        /// <b>Post:</b> The earthquake is instanciated.
        /// </summary>
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
        /// <summary>
        /// The toString that returns info about the magnitude and the place where the earthquake occurred
        /// </summary>
        /// <returns>An string with the information</returns>
        public override string ToString()
        {
            return "Mag: "+Magnitude+" - "+Place;
        }
        /// <summary>
        /// This method gets the date from the value Time in a Date format to be shown in the interface
        /// </summary>
        /// <returns>The date where the earthquake occurred</returns>
        public string GetDate()
        {
            var localDateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(Time).DateTime.ToLocalTime();            
            return localDateTimeOffset.ToString("MMM dd yyyy");

        }
        /// <summary>
        /// This method gets the hour from the value Time in an hour format to be shown in the interface
        /// </summary>
        /// <returns>The hour where the earthquake occurred</returns>
        public string GetHour()
        {
            var localDateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(Time).DateTime.ToLocalTime();
            return localDateTimeOffset.ToString("hh:mm tt");
        }


    }
}
