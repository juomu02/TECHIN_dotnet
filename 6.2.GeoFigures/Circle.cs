public class Circle : Shape
{
    public double Radius;

    public Circle()
    {
    }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * Radius * Radius, 3);
    }
    public override double GetPerimeter()
    {
        return Math.Round(2 * Math.PI * Radius, 3);
    }
}