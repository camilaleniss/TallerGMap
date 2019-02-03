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
        /// <summary>
        /// The connection with the main window
        /// </summary>
        public Window Window { private get; set; }

        /// <summary>
        /// The constructor from the Earthquakes control
        /// </summary>
        public EarthquakesControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getter of the listview 
        /// </summary>
        /// <returns></returns>
        public ListView getListEarthquakes()
        {
            return listEarthquakes;
        }

        private void InitializeEarthquakes()
        {

        }

        private void listEarthquakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listEarthquakes.SelectedIndices.Count > 0)
            {
                int index = listEarthquakes.SelectedIndices[0];
                this.Window.SelectEarthquake(index);
            }
            
        }
    }
}
