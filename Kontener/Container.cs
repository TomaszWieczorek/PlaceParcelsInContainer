using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontener
{
    public class Container
    {
        public Container(double X, double Y)
        {
            this.containerSizeX = X;
            this.containerSizeY = Y;
            this.containerSize = Math.Round(this.containerSizeX * this.containerSizeY, 2);
        }
        public double containerSizeX { get; set; } //container width
        public double containerSizeY { get; set; } //container height
        public double containerSize { get; } //container size in m^2
    }
}
