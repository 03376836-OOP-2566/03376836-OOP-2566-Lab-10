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

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-10/assets/144195995/759b9773-5da6-4662-8f09-2459f322d6fd)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-10/assets/144195995/730b990b-647f-498b-bd64-35f06cfce809)

7.อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ เพราะเป็น private แก้จากเปลี่ยน private Shape() เป็น public Shape()
โปรแกรมจะแสดงผล
This is some shape with unknown side
This is a circle
This is some shape with 4 sides
This is a rectangle
This is some shape with 3 sides
This is a triangle
