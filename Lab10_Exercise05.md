# Lab 10 Exercise 5

## การเรียก constructor ด้วย keyword `this`

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex05
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
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
   public Triangle() : base( ) // Hint: add number of size as parameters
    {
        System.Console.WriteLine("This is a triangle");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="704" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-10/assets/144195963/2d23916c-da93-4ae9-8b1b-f7c9b05f03a0">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="698" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-10/assets/144195963/f61eb645-1850-43a7-b7b6-3f3537e69ea3">

7.อธิบายสิ่งที่พบในการทดลอง

หากแก้ไขได้โปรแกรมจะแสดงผล
This is some shape with 0 sides
This is a circle
This is some shape with 4 sides
This is a rectangle
This is a triangle
