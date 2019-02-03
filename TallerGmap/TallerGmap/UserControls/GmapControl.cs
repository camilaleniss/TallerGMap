using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace TallerGmap.UserControls
{
    /// <summary>
    /// This class has the GMap control for the visualization of the marks in the places where had been occurred a earthquake
    /// </summary>
    public partial class GmapControl : UserControl
    {
        /// <summary>
        /// The constructor of the class
        /// </summary>
        public GmapControl()
        {
            InitializeComponent();
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.Position = new PointLatLng(-25.971684, 32.589759);
        }
        /// <summary>
        /// Adds a marker in the map with the given coordinates
        /// </summary>
        /// <param name="coordinates">Coordinates of the earthquake. coordinates[0]=longitude, coordinates[1]=latitude </param>
        public void AddMarker(double []coordinates) 
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(coordinates[0], coordinates[1]),
              GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gMap.Overlays.Add(markersOverlay);
        }
    }
}
