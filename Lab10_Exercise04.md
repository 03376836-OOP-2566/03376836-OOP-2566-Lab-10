# Lab 10 Exercise 4

## private constructor

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex04
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/e0097a3a-9dbd-40b5-a4df-b9ce82e5be7e)

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

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/15e8e1f7-18e8-4793-a07c-1207a885975a)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/a303f38c-d908-440c-b2a3-6bbc4f547c6c)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/d80830d2-1539-4ba6-a006-803058a7207d)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/3fe69134-6655-4b5a-9fbd-2affa0d8e100)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/9358f351-2879-43f7-a50f-7e1d9fd627fc)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้ คลาส Shape มีคอนสตรักเตอร์สองแบบ: คอนสตรักเตอร์เริ่มต้นที่ไม่มีการรับพารามิเตอร์และคอนสตรักเตอร์ที่รับพารามิเตอร์ที่บอกจำนวนด้านของรูปทรง โดยมีการใช้โมดิไฟเออร์ private เพื่อป้องกันการสร้างอ็อบเจกต์โดยตรง
คลาส Circle, Rectangle, และ Triangle สืบทอดคุณสมบัติจาก Shape โดยมีการเรียกใช้คอนสตรักเตอร์ของ Shape ผ่าน base() เพื่อแสดงข้อความเริ่มต้นของ Shape และระบุจำนวนด้านของรูปทรง
สรุป
เมื่อสร้างอ็อบเจกต์ของ Circle จะแสดงข้อความ "This is some shape with unknown side" และ "This is a circle"

เมื่อสร้างอ็อบเจกต์ของ Rectangle จะแสดงข้อความ "This is some shape with 4 sides" และ "This is a rectangle"

เมื่อสร้างอ็อบเจกต์ของ Triangle จะแสดงข้อความ "This is some shape with 3 sides" และ "This is a triangle"
เราจะเห็นได้จากภาพด้านบน ที่มีการแสดงผลทางข้อมูล
