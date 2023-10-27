
using ExemploMetodoAbstrato.Entities.Enums;

namespace ExemploMetodoAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        public Shape()
        {
        }

        public abstract double Area();
    }
}