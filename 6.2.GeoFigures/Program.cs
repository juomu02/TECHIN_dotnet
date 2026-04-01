//1. Sukurkite naują projektą GeoFigures;
//2. Aprašykite klasė Circle su Radius property;
//3. Aprašykite klasė Triangle su Base ir Height properties;
//4. Sukurkite keleta Circle ir Triangle objektų Main metode;
//5. Aprašykite Rectangle klasę. Pridėkite Width ir Height property. Patikrinkite ar reikšmės teigiamos;
//6. Kiekvienoje iš aprašytu klasių pridėkite metodus GetArea() ir GetPerimeter(). Aprašykite jų funkcialumą.

public class GeoFigures
{
    public static void Main()
    {
        Circle circle = new Circle(3.0);
        Triangle triangle = new Triangle(2, 1);
        Rectangle rectangle = new Rectangle(5, 1);
        var rectArea = rectangle.GetArea();
        var rectPerimeter = rectangle.GetPerimeter();

        var circleEmpty = new Circle();
        var triangleEmpty = new Triangle();
        var rectangleEmpty = new Rectangle();
        Console.WriteLine($"circle empty area: {circleEmpty.GetArea()} units²; triangle empty area: {triangleEmpty.GetArea()} units²; rectangle empty area: {rectangleEmpty.GetArea()} units²;");

        Console.WriteLine($"Rectangle area is {rectArea} units² and perimeter is {rectPerimeter} units.");

        var circleArea = circle.GetArea();
        var circlePerimeter = circle.GetPerimeter();
        Console.WriteLine($"Circle area is {circleArea} units² and perimeter is {circlePerimeter} units.");

        var triangleArea = triangle.GetArea();
        var trianglePerimeter = triangle.GetPerimeter();
        Console.WriteLine($"Triangle area is {triangleArea} units² and perimeter is {trianglePerimeter} units.");

    }
}