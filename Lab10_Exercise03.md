# Lab 10 Exercise 3

## การส่งค่าไปยัง constructor ของ base class

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex03
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;
    public Shape()
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
dotnet build  Lab10_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![3](https://github.com/Siriratda/03376836-OOP-2566-Lab-10/assets/144195995/3d74c121-c0ea-4111-8974-a9ac98bac7ac)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![3 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-10/assets/144195995/71b16614-72a5-4a48-a68a-e6f8aa821ea2)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ ในคลาสที่สืบทอด (Circle, Rectangle, Triangle) มีการใช้ base() เพื่อเรียก Constructor ของคลาสฐาน (Shape) ซึ่งจะทำให้ Constructor ของ Shape ที่รับพารามิเตอร์ถูกเรียกใช้
โปรแกรมจะแสดงผล
This is some shape with unknown side
This is a circle
This is some shape with 4 sides
This is a rectangle
This is some shape with 3 sides
This is a triangle
