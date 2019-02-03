using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace TallerGmap.Model
{
    /// <summary>The class that contains the earthquakes and obtains them.</summary>
    public class Earth
    {

        /// <summary>the minimum magnitude that the earthquakes in the list will have.</summary>
        public const double MINIMUM_MAGNITUDE = 4;

        /// <summary>The location of the json file with the Earthquakes.</summary>
        public const string JSON_LOCATION = "..\\..\\Earthquakes.json";

        /// <summary>The url of the USGS api.</summary>
        public const string API_URL = "https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson";

        /// <summary>The list that contains the earthquakes.</summary>
        public List<Earthquake> Earthquakes;

        /// <summary>The currently selected earthquake.</summary>
        public Earthquake SelectedEarthquake;

        /// <summary>
        ///  Constructor method of the Earth class. <para/>
        /// <b>Post:</b> The earthquakes list is instanciated.
        /// </summary>
        public Earth()
        {
            Earthquakes = new List<Earthquake>();
            UpdateEarthquakes();
        }

        /// <summary>
        ///  Gets the earthquakes from the specified <paramref name="url"/>. <para/>
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
        ///  Writes the JSON information <paramref name="earthquakesJson"/> in the default location. <para/>
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
        /// <param name="startTime">The starting date for the earthquakes. It must be in yyyy-MM-dd format.</param>
        /// <param name="minMagnitude">The minimum magnitude for the earthquakes. It must be a positive decimal number.</param>
        /// <returns>Returns an url to the api with the given parameters.</returns>
        private string MakeUrl(string startTime, double minMagnitude)
        {
            StringBuilder url = new StringBuilder(API_URL);
            url.Append("&starttime=" + startTime);
            url.Append("&minmagnitude=" + minMagnitude);
            return url.ToString();
        }

        /// <summary>
        /// Downloads the list of earthquakes from the api and writes it in a file.
        /// </summary>
        /// /// <exception cref="System.Net.WebException">This exception is thrown if the user is not connected to the internet</exception>
        public void DownloadEarthquakes()
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string url = MakeUrl(date, MINIMUM_MAGNITUDE);
            string json = GetEarthquakesJson(url);
            WriteEarthquakes(json);
        }

        /// <summary>
        /// Updates the list of earthquakes using, if possible, the api.
        /// </summary>
        public void UpdateEarthquakes()
        {
            try
            {
                DownloadEarthquakes();
            } catch(WebException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            LoadEarthquakes();
        }

        /// <summary>
        /// Loads the earthquakes from the file to the list.
        /// </summary>
        public void LoadEarthquakes()
        {
            string json = ReadEarthquakes();
            CreateEarthquakes(json);
        }

        /// <summary>
        /// Reads the json with the earthquakes from the file.
        /// </summary>
        /// <returns>Returns the json with the earthquakes from the file.</returns>
        private string ReadEarthquakes()
        {
            String line;
            StringBuilder sb = new StringBuilder();
            try
            {
                StreamReader sr = new StreamReader(JSON_LOCATION);
                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    sb.Append(line);
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Uses the json with the earthquakes to create the list of earthquakes
        /// </summary>
        /// <param name="json">The json with the earthquakes from the file.</param>
        private void CreateEarthquakes(string json)
        {
            //Instance a dynamic object using the json with the earthquakes
            dynamic jsonObject = JsonConvert.DeserializeObject(json); 
            if (jsonObject.metadata.count > 0) //If there are earthquakes
            {
                for (int i = 0; i < jsonObject.features.Count; i++)
                {
                    //Gets each feature (earthquake) to obtain the info
                    dynamic earthquakeInfo = jsonObject.features[i];

                    string place = earthquakeInfo.properties.place;
                    long time = earthquakeInfo.properties.time;
                    double longitude = earthquakeInfo.geometry.coordinates[0];
                    double latitude = earthquakeInfo.geometry.coordinates[1];
                    double magnitude = earthquakeInfo.properties.mag;
                    string url = earthquakeInfo.properties.url;

                    Earthquake current = new Earthquake(place, time, longitude, latitude, magnitude, url);

                    Earthquakes.Add(current);
                }
            }
        }

        /// <summary>
        /// Sets the selected earthquake to the earthquake in the given index.<para/>
        /// <b>Pre:</b> The earthquakes list is not null and has at least one earthquake.<para/>
        /// <b>Post:</b> The selected earthquake is the earthquake in the given index.
        /// </summary>
        /// <param name="index">The index of the earthquake. It must be a valid index for the list of earthquakes.</param>
        public void SelectEarthquake(int index)
        {
            SelectedEarthquake = Earthquakes[index];
        }

        /// <summary>
        /// Returns the place of the selected earthquake. If there is no selected earthquake, returns "-".
        /// </summary>
        /// <returns>Returns the place of the selected earthquake. If there is no selected earthquake, returns "-".</returns>
        public string GetSelectedPlace()
        {
            string place = "-";
            if(SelectedEarthquake != null)
            {
                place = SelectedEarthquake.Place;
            }
            return place;
        }

        /// <summary>
        /// Returns the magnitude of the selected earthquake. If there is no selected earthquake, returns 0.
        /// </summary>
        /// <returns>Returns the magnitude of the selected earthquake. If there is no selected earthquake, returns 0.</returns>
        public double GetSelectedMagnitude()
        {
            double magnitude = 0;
            if (SelectedEarthquake != null)
            {
                magnitude = SelectedEarthquake.Magnitude;
            }
            return magnitude;
        }

        /// <summary>
        /// Returns the longitude of the selected earthquake. If there is no selected earthquake, returns 0.
        /// </summary>
        /// <returns>Returns the longitude of the selected earthquake. If there is no selected earthquake, returns 0.</returns>
        public double GetSelectedLongitude()
        {
            double longitude = 0;
            if (SelectedEarthquake != null)
            {
                longitude = SelectedEarthquake.Longitude;
            }
            return longitude;
        }

        /// <summary>
        /// Returns the latitude of the selected earthquake. If there is no selected earthquake, returns 0.
        /// </summary>
        /// <returns>Returns the latitude of the selected earthquake. If there is no selected earthquake, returns 0.</returns>
        public double GetSelectedLatitude()
        {
            double latitude = 0;
            if (SelectedEarthquake != null)
            {
                latitude = SelectedEarthquake.Latitude;
            }
            return latitude;
        }

        /// <summary>
        /// Returns the date of the selected earthquake. If there is no selected earthquake, returns "-".
        /// </summary>
        /// <returns>Returns the date of the selected earthquake. If there is no selected earthquake, returns "-".</returns>
        public string GetSelectedDate()
        {
            string date = "-";
            if (SelectedEarthquake != null)
            {
                date = SelectedEarthquake.GetDate();
            }
            return date;
        }

        /// <summary>
        /// Returns the hour of the selected earthquake. If there is no selected earthquake, returns "-".
        /// </summary>
        /// <returns>Returns the hour of the selected earthquake. If there is no selected earthquake, returns "-".</returns>
        public string GetSelectedHour()
        {
            string hour = "-";
            if (SelectedEarthquake != null)
            {
                hour = SelectedEarthquake.GetHour();
            }
            return hour;
        }

        /// <summary>
        /// If there is a selected earthquake, opens its url.
        /// </summary>
        public void OpenUrl()
        {
            if (SelectedEarthquake != null)
            {
                System.Diagnostics.Process.Start(SelectedEarthquake.Url);
            }
        }
        
    }
}
