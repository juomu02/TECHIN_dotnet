class ShapeHelper
{
    public static double CalculateArea(List<Shape> shapeList)
    {
        double totalArea = 0;
        shapeList.ForEach(o =>
        {
            totalArea += o.GetArea();
        });
        return totalArea;
    }
    public static double CalculatePerimeter(List<Shape> shapeList)
    {
        double totalPerimeter = 0;
        shapeList.ForEach(o =>
        {
            totalPerimeter += o.GetPerimeter();
        });
        return totalPerimeter;
    }
}