# Lab 10 Exercise 3

## การส่งค่าไปยัง constructor ของ base class

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex03
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/58a6b5ac-e2f5-48a7-9909-77a999cc2c0f)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/fe93aa00-e2f2-40d7-ba65-2c8f8f696653)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/2ea79b5b-aee1-452f-b290-38169691eab7)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/5a581b93-4263-427f-ba5a-956c111e1d52)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/9615faa8-86cd-45a0-95ef-97b0fff62b55)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/e4d5e611-688c-4580-b1ff-0d6754579d56)

7.อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้มีการสร้างคลาส Shape ที่มีคอนสตรักเตอร์ทั้งสองรูปแบบ คอนสตรักเตอร์เริ่มต้นที่ไม่มีพารามิเตอร์และคอนสตรักเตอร์ที่รับพารามิเตอร์จำนวนด้านของรูปทรง และแสดงจำนวนด้านของรูปทรงในข้อความที่แสดงออกมา สรุป
เมื่อสร้างอ็อบเจกต์ของ Circle จะแสดงข้อความ "This is some shape with unknown side" และ "This is a circle"

เมื่อสร้างอ็อบเจกต์ของ Rectangle จะแสดงข้อความ "This is some shape with 4 sides" และ "This is a rectangle"

เมื่อสร้างอ็อบเจกต์ของ Triangle จะแสดงข้อความ "This is some shape with 3 sides" และ "This is a triangle"

จากการทดลองจะแสดงผลดังภาพด้านบน
