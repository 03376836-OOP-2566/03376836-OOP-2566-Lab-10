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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/18335d2f-bfac-40e1-bd6b-1fa184e98b9e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/7adf588e-462e-48e8-a9b3-62678e470c89)

7.อธิบายสิ่งที่พบในการทดลอง
- คลาส Circle มีการเรียกใช้คอนสตรักเตอร์ของคลาสแม่ Shape โดยใช้ base() เพื่อเรียกใช้คอนสตรักเตอร์ที่ไม่รับพารามิเตอร์ของ Shape ซึ่งจะแสดง "This is some shape with unknown side"  และจากนั้นคอนสตรักเตอร์ของ Circle จะแสดง"This is a circle" 
- คลาส Rectangle มีการเรียกใช้คอนสตรักเตอร์ของคลาสแม่ Shape โดยใช้ base(4) เพื่อส่งค่า 4 เข้าไปยังคอนสตรักเตอร์ของ Shape ซึ่งจะแสดง "This is some shape with 4 sides" 
- คลาส Triangle มีการเรียกใช้คอนสตรักเตอร์ของคลาสแม่ Shape โดยใช้ base(3) เพื่อส่งค่า 3 เข้าไปยังคอนสตรักเตอร์ของ Shape ซึ่งจะแสดง"This is some shape with 3 sides"  และจากนั้นคอนสตรักเตอร์ของ Triangle จะแสดง"This is a triangle" 
