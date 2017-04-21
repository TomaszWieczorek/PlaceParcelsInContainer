using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontener
{
    public class Coordinates
    {
        public Coordinates(double X, double Y)
        {
            this.coordinateX = X;
            this.coordinateY = Y;
        }
        public double coordinateX { get; set; }
        public double coordinateY { get; set; }
    }
}
