# Lab 10 Exercise 1

## Constructors

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex01
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var shape = new Shape();
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
class Circle
{
    public Circle()
    {
        System.Console.WriteLine("This is a circle");
    }
}
class Rectangle
{
    public Rectangle()
    {
        System.Console.WriteLine("This is a rectangle");
    }
}
class Triangle
{
   public Triangle()
    {
        System.Console.WriteLine("This is a triangle");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/203d982b-19ac-438a-ad88-54de9c11ffe1)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/8eb6d3ca-be39-4fd0-8c54-00bc29bc78a7)

7.อธิบายสิ่งที่พบในการทดลอง
- สร้างคลาส Shape, Circle, Rectangle, และ Triangle แต่ละคลาสมีconstructorที่ถูกเรียกเมื่อสร้างอ็อบเจกต์ของคลาสนั้นconstructorจะพิมพ์ข้อความที่ระบุชนิดของรูปทรงที่ถูกสร้างขึ้น
- สร้างอ็อบเจกต์ของคลาส Circle จะทำให้พิมพ์ข้อความ "This is a circle" ออกทางหน้าจอ

- สร้างอ็อบเจกต์ของคลาส Rectangle จะทำให้พิมพ์ข้อความ "This is a rectangle" ออกทางหน้าจอ

- สร้างอ็อบเจกต์ของคลาส Triangle จะทำให้พิมพ์ข้อความ "This is a triangle" ออกทางหน้าจอ




