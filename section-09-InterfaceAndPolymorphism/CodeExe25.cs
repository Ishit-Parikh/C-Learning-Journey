namespace Section09;

/*
Create a simple C# program that demonstrates polymorphism using interfaces. The program should:
Declare an interface IShape with a method double GetArea().
Create two classes, Circle and Rectangle, that implement the IShape interface.
The Circle class should have a constructor that takes a radius and implements the GetArea method to return the area of the circle.
The Rectangle class should have a constructor that takes width and height, and implements the GetArea method to return the area of the rectangle.
In the PrintAreas method, create an array of IShape containing instances of Circle and Rectangle, and print the area of each shape to the console.

Alert!
The result of execution should be the area of each shape printed to the console.
Example:
For a Circle with radius 5 and a Rectangle with width 4 and height 6, the output should be:
Area: 78.53981633974483\nArea: 24\n
*/

public interface IShape
{
    public double GetArea();
}

public class Circle: IShape
{
    private double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}

public class Rectangle: IShape
{
    private double _width, _height;
    public Rectangle(double width, double height)
    {
        _height = height;
        _width = width;
    }

    public double GetArea()
    {
        double area =  _width * _height;
        return area;
    }
}

public class CodeExe25
{
    public static void Run()
    {
        IShape[] shapes = new IShape[]
        {
            new Circle(5.0),
            new Rectangle(4.0,6.0)
        };

        foreach(IShape shape in shapes)
        {
            System.Console.WriteLine($"Area: {shape.GetArea()}");
        }
    } 
}