using ClasseAbstrata.Enums;

namespace ClasseAbstrata.Entities
{
    abstract class Shape
    {
        public Color Color {get; set;}
        public abstract double Area();
    }
}