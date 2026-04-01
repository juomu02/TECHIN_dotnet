public class Triangle
{
    public double Base;
    public double Height;

    public Triangle()
    {
    }
    public Triangle(double triangleBase, double height)
    {
        Base = triangleBase;
        Height = height;
    }
    public double GetArea()
    {
        return Math.Round(Base * Height / 2, 3);
    }
    public double GetPerimeter()
    {
        var side = Math.Sqrt(Height * Height + Base * Base / 4);
        return Math.Round(Base + side * 2, 3);
    }
}