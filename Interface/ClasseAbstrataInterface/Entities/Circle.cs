using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ClasseAbstrataInterface.Enums;

namespace ClasseAbstrataInterface.Entities
{
    class Circle : IShape
    {
        public double Radius {get; set;}
        public AbstractShape Color{get; set;}

        public double Area(){
            return Math.PI  * Radius * Radius;
        }

         public override string ToString()
        {
            return "Circle color = "
            + Color
            + ", Radius = "
            + Radius.ToString("F2", CultureInfo.InvariantCulture)
            + ", Area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}