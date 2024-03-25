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

<img width="493" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-10/assets/144195963/32177165-7c54-4a16-811d-276312ee1f98">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="419" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-10/assets/144195963/27c11b14-fa06-4967-8507-f1a33f15c3d6">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล
This is some shape
This is a circle
This is a rectangle
This is a triangle
