var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    private Shape()
    {
    }

    public Shape(int NumOfSide) : this()
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0)
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // ส่งค่า 3 เพื่อระบุว่าเป็นสามเหลี่ยม (มี 3 ด้าน)
    {
        System.Console.WriteLine("This is a triangle");
    }
}
