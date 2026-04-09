using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 3);
        Rectangle rectangle = new Rectangle("blue", 5, 3);
        Circle circle = new Circle("purple", 2);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape color is {color}, and the area is {area}");
        }


    }

}