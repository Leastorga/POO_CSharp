using System.Globalization;


namespace ClasseAbstrata.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
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