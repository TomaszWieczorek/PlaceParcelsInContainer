using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontener
{
    public class Parcel
    {
        public Parcel(string Number, double X, double Y)
        {
            this.parcelNumberID = Number;
            this.parcelSizeX = X;
            this.parcelSizeY = Y;
            this.parcelSize = Math.Round(this.parcelSizeX * this.parcelSizeY,2);
        }
        public string parcelNumberID { get; set; } //number of parcel
        public double parcelSizeX { get; set; } //parcel width
        public double parcelSizeY { get; set; } //parcel height
        public double parcelSize { get; } //parcel size in m^2
    }
}
