using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerGmap.UserControls
{
    public partial class EarthquakesControl : UserControl
    {

        private Window window;
        /// <summary>
        /// The constructor from the Earthquakes control
        /// </summary>
        public EarthquakesControl(Window window)
        {
            this.window = window;
            InitializeComponent();
        }

        public ListView getListEarthquakes()
        {
            return listEarthquakes;
        }

        private void InitializeEarthquakes()
        {

        }

        private void listEarthquakes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
