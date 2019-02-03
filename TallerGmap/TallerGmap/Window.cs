using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerGmap.Model;

namespace TallerGmap
{
    public partial class Window : Form
    {
        /// <summary>
        /// The link with the model
        /// </summary>
        private Earth earth;

        /// <summary>
        /// The constructor of the main Window
        /// </summary>
        public Window()
        {
            this.Icon = new Icon("..\\..\\res\\earthquake.ico");
            InitializeComponent();
            earth = new Earth();
            InitializeEarthquakes();
            earthquakesControl.Window = this;
            infoControl.Window = this;
            gmapControl.Window = this;
        }
        /// <summary>
        /// This method initialize the earthquakes shown in the list and in the map.
        /// </summary>
        public void InitializeEarthquakes()
        {
            InitializeList();
            InitializeMap();
        }
        /// <summary>
        /// This method initialize the list with the earthquakes in the Earth
        /// </summary>
        public void InitializeList()
        {
            List <Earthquake> earthquakes = earth.Earthquakes;
            foreach(Earthquake e in earthquakes)
            {
                earthquakesControl.getListEarthquakes().Items.Add(e.ToString());
            }
        }
        /// <summary>
        /// This method initialize the marks in the map where an earthquake had been occurred
        /// </summary>
        public void InitializeMap()
        {
            double[] coordinates = new double[2];
            foreach (Earthquake e in earth.Earthquakes)
            {
                coordinates[0] = e.Longitude;
                coordinates[1] = e.Latitude;
                gmapControl.AddMarker(coordinates, e.Url);
            }
        }

        /// <summary>
        /// This method changes the info of the selected Earthquake
        /// </summary>
        private void ModifyInfo()
        {
            
            gmapControl.ShowEarthquake(earth.GetSelectedLatitude(), earth.GetSelectedLongitude());
            string[] info = new string[6];
            info[0] = earth.GetSelectedPlace();
            info[1] = earth.GetSelectedMagnitude().ToString();
            info[2] = earth.GetSelectedLongitude().ToString();
            info[3] = earth.GetSelectedLatitude().ToString();
            info[4] = earth.GetSelectedDate();
            info[5] = earth.GetSelectedHour();

            infoControl.modifyInformation(info);
        }

        /// <summary>
        /// Selects the earthquake with the given index
        /// </summary>
        /// <param name="index">The index of the earthquake</param>
        public void SelectEarthquake(int index)
        {
            earth.SelectEarthquake(index);
            ModifyInfo();
        }

        /// <summary>
        /// Selects the earthquake with the given url
        /// </summary>
        /// <param name="url">The url of the earthquake</param>
        public void SelectEarthquake(string url)
        {
            earth.SelectEarthquake(url);
            ModifyInfo();
        }

        /// <summary>
        /// This method opens the url to show more information about the earthquake
        /// </summary>
        public void OpenURL()
        {
            earth.OpenUrl();
        }

    }
}
