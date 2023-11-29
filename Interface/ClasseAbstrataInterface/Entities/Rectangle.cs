using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataInterface.Entities
{
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public AbstractShape Color { get; set; }

        public double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "Rectangle color = "
            + Color
            + ", Width = "
            + Width.ToString("F2", CultureInfo.InvariantCulture)
            + ", Height = "
            + Height.ToString("F2", CultureInfo.InvariantCulture)
            + ", Area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}