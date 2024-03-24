using System;

class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle();
        var rectangle = new Rectangle();
        var triangle = new Triangle(3); // Pass the number of sides for Triangle
    }
}

class Shape
{
    private int? NumOfSide;
    private Shape()
    {
    }
    public Shape(int NumOfSide) : this()
    {
       this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides" );
    }
}
class Circle :Shape
{
    public Circle():base(0)
    {
        System.Console.WriteLine("This is a circle");
    }
}
class Rectangle :Shape
{
    public Rectangle(): base(4)
    {
        System.Console.WriteLine("This is a rectangle");
    }
}
class Triangle :Shape
{
   public Triangle(int numOfSides) : base(numOfSides) // Pass the number of sides as parameters
    {
        System.Console.WriteLine("This is a triangle");
    }
}
