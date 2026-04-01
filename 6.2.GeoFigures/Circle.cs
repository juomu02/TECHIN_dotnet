public class Circle
{
    public double Radius;

    public Circle()
    {
    }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.Round(Math.PI * Radius * Radius, 3);
    }
    public double GetPerimeter()
    {
        return Math.Round(2 * Math.PI * Radius, 3);
    }
}