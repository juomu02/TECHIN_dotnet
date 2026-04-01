public class Rectangle
{
    private double _width;
    private double _height;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            { throw new ArgumentException("Parameter Width cannot be negative or 0"); }
            else
            { _width = value; }
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            { throw new ArgumentException("Parameter Height cannot be negative or 0"); }
            else
            { _height = value; }
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Math.Round(_height * _width, 3);
    }
    public double GetPerimeter()
    {
        return Math.Round(2 * _height + 2 * _width, 3);
    }
}