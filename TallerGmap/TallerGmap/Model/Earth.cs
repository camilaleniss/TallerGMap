using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace TallerGmap.Model
{
    public class Earth
    {

        /// <summary>The location of the json file with the Earthquakes.</summary>
        public const string JSON_LOCATION = "..\\..\\Earthquakes.json";

        /// <summary>The url of the USGS api.</summary>
        public const string API_URL = "https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson";

        /// <summary>The list that contains the earthquakes.</summary>
        private List<Earthquake> earthquakes;

        /// <summary>The currently selected earthquake.</summary>
        private Earthquake selectedEarthquake;

        /// <summary>
        ///  Constructor method of the Earth class. <para>
        /// <b>Post:</b> The earthquakes list is instanciated.
        /// </summary>
        public Earth()
        {
            earthquakes = new List<Earthquake>();
            UpdateEarthquakes();
        }

        /// <summary>
        ///  Gets the earthquakes from the specified <paramref name="url"/>. <para>
        /// </summary>
        /// <param name="url">The url that containts the information about the Earthquakes in JSON format.</param>
        /// <returns>Returns a string with the JSON of the earthquakes.</returns>
        /// <exception cref="System.Net.WebException">This exception is thrown if the user is not connected to the internet</exception>
        private string GetEarthquakesJson(string url)
        {
            // Creates the request
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);

            //Gets the response
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            //Writes the response into a string
            string sLine = "";
            int i = 0;
            StringBuilder sb = new StringBuilder();
            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    sb.Append(sLine);
            }
            return sb.ToString();
        }

        /// <summary>
        ///  Writes the JSON information <paramref name="earthquakesJson"/> in the default location. <para>
        /// <b>Post:</b> The earthquakes list is written into a file in the default location.
        /// </summary>
        /// <param name="earthquakesJson">The JSON that contains the information of the earthquakes.</param>
        private void WriteEarthquakes(string earthquakesJson)
        {
            try
            {

                StreamWriter sw = new StreamWriter(JSON_LOCATION, false);

                sw.WriteLine(earthquakesJson);

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        /// <summary>
        /// Makes an url to the api with the given parameters.
        /// </summary>
        /// <param name="startTime">The starting date for the earthquakes. It must be in YYYY-MM-DD format.</param>
        /// <param name="minMagnitude">The minimum magnitude for the earthquakes. It must be a positive decimal number.</param>
        /// <returns>Returns an url to the api with the given parameters.</returns>
        private string MakeUrl(string startTime, double minMagnitude)
        {
            StringBuilder url = new StringBuilder(API_URL);
            url.Append("&starttime=" + startTime);
            url.Append("&minmagnitude=" + minMagnitude);
            return url.ToString();
        }



        public void UpdateEarthquakes()
        {
            string url = MakeUrl("2015-01-01", 8); //Example
            string json = GetEarthquakesJson(url);
            Console.WriteLine(json);
            WriteEarthquakes(json);
        }
    }
}
