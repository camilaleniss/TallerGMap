using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerGmap.Model
{
    public class Earthquake
    {
        private long time;
        private int longitud;
        private int latitud;
        private double magnitud;

        public Earthquake(long time, int longitud, int latitud, double magnitud)
        {
            this.time = time;
            this.longitud = longitud;
            this.latitud = latitud;
            this.magnitud = magnitud;
        }




    }
}
