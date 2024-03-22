# Lab 10 Exercise 2

## Constructor ใน derived class

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex02
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/d3d739d0-cec7-4caf-aa41-d7211c398811)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    public Shape()
    {
        System.Console.WriteLine("This is some shape");
    }
}
class Circle :Shape
{
    public Circle()
    {
        System.Console.WriteLine("This is a circle");
    }
}
class Rectangle :Shape
{
    public Rectangle()
    {
        System.Console.WriteLine("This is a rectangle");
    }
}
class Triangle :Shape
{
   public Triangle()
    {
        System.Console.WriteLine("This is a triangle");
    }
}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/d37da3ea-492d-4e2a-80bd-0de00b1db0c5)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/9173ccc1-e19a-4521-bc92-246c006a8e9f)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/064372c3-f000-4ed6-a209-3552fd3014f6)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/3297c036-e5fb-4f5b-ac99-27f7c73923f2)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เป็นการสร้างคลาสที่สืบทอดจากคลาส Shape เพื่อสร้างอ็อบเจกต์ของรูปทรงต่างๆ โดยแต่ละคลาสที่สืบทอดจะมีการแสดงข้อความต่างกันในคอนสตรักเตอร์
สรุป
เมื่อสร้างอ็อบเจกต์ของ Circle จะแสดงข้อความ "This is some shape" และ "This is a circle"

เมื่อสร้างอ็อบเจกต์ของ Rectangle จะแสดงข้อความ "This is some shape" และ "This is a rectangle"

เมื่อสร้างอ็อบเจกต์ของ Triangle จะแสดงข้อความ "This is some shape" และ "This is a triangle"
ดังภาพด้านบนที่มีการแสดงผลออกมา


