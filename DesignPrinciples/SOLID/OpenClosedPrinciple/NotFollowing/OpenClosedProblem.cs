namespace DesignPrinciples.SOLID.OpenClosedPrinciple.NotFollowing
{
    internal class OpenClosedProblem
    {
        // Not following OCP
        public class Shape
        {
            public string Type { get; set; }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
        }

        public class Rectangle : Shape
        {
            public double Length { get; set; }
            public double Width { get; set; }
        }

        public class AreaCalculator
        {
            public double CalculateArea(Shape[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    if (shape.Type == "Circle")
                    {
                        var circle = (Circle)shape;
                        area += Math.PI * circle.Radius * circle.Radius;
                    }
                    else if (shape.Type == "Rectangle")
                    {
                        var rectangle = (Rectangle)shape;
                        area += rectangle.Length * rectangle.Width;
                    }
                    // Adding more shapes will require modifying this class
                }
                return area;
            }
        }
    }
}
