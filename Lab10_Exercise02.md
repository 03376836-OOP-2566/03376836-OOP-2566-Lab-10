# Lab 10 Exercise 2

## Constructor ใน derived class

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex02
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/20125b8c-9b17-41e5-a2db-cb4c202e0213)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/d6817b69-dafe-4419-8473-4fe2e6688659)

7.อธิบายสิ่งที่พบในการทดลอง
- สร้างและใช้อ็อบเจกต์ของคลาส Circle, Rectangle, และ Triangle ซึ่งทั้ง 3 คลาสนี้สืบทอดคุณสมบัติจากคลาส Shape โดยทุกคลาสลูกจะมีconstructorที่สร้างอ็อบเจกต์และพิมพ์ข้อความระบุชนิดของรูปทรงที่ถูกสร้างขึ้น 

