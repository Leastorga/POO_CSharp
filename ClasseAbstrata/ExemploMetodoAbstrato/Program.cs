using System;
using System.Globalization;
using ExemploMetodoAbstrato.Entities;
using ExemploMetodoAbstrato.Entities.Enums;

namespace ExemploMetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or circle (r/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (answer == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Circle circle = new Circle(color, radius);
                    list.Add(circle);
                }
                else
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Rectangle rectangle = new(color, width, height);
                    list.Add(rectangle);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape item in list)
            {
                Console.WriteLine(item.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }



        }
    }
}