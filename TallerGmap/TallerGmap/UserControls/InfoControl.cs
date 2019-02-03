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
    /// <summary>
    /// This class show the information of the selected Earthquake
    /// </summary>
    public partial class InfoControl : UserControl
    {
        /// <summary>
        /// The connection with the main window
        /// </summary>
        public Window Window { private get; set; }

        /// <summary>
        /// The constructor of the class
        /// </summary>
        public InfoControl()
        {
            InitializeComponent();  
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            Window.OpenURL();
        }
        /// <summary>
        /// This method modifies the information in the labels with the new information in the array
        /// </summary>
        /// <param name="information">The array with the information of the Earthquake</param>
        public void modifyInformation(string [] information)
        {
            labInfoPlace.Text = information[0];
            labInfoMag.Text = information[1];
            labInfoLong.Text = information[2];
            labInfoLat.Text = information[3];
            labInfoDate.Text = information[4];
            labInfoHour.Text = information[5];
        }

    }
}
