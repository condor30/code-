public interface IShape
{
    double Area();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Triangle : IShape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public double Area()
    {
        double semiPerimeter = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
    }

    public bool IsRightTriangle()
    {
        // Check if the triangle is a right triangle using Pythagorean theorem
        return Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2) ||
               Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2) ||
               Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2);
    }
}

public class ShapeCalculator
{
    public double Area(IShape shape)
    {
        return shape.Area();
    }
}
