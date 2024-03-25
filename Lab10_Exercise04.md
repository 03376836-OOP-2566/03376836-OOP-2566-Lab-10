# Lab 10 Exercise 14

## private constructor

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex04
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
        System.Console.WriteLine("This is some shape with unknown side");
    }
    public Shape(int NumOfSide)
    {
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides" );
    }
}
class Circle :Shape
{
    public Circle():base()
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
   public Triangle() : base(3)
    {
        System.Console.WriteLine("This is a triangle");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="701" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-10/assets/144195963/a11ea846-3087-4208-96eb-a9298f0ef338">

แก้ไม่ได้
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="689" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-10/assets/144195963/86f37c23-2bc8-4fae-8169-b958d5d2100d">

แก้ไม่ได้

7.อธิบายสิ่งที่พบในการทดลอง

ในกรณีที่โปรแกรมสามารถใช้งานได้ โปรแกรมจะแสดงผล
This is some shape with unknown side
This is a circle
This is some shape with 4 sides
This is a rectangle
This is some shape with 3 sides
This is a triangle
