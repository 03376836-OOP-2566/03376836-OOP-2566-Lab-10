# Lab 10 Exercise 1

## Constructors

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex01
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/ba803b81-3cab-4e5e-80ca-ce2597000432)

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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/1d30132e-4c8e-4ebe-b842-ed24d1b23e73)
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/8f418d32-7ac1-46e9-8bf6-94d72a04bca7)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/58c5304c-c9cd-4465-b4af-ceceb94b0f98)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/0abd6d63-9dd3-4283-bdd1-24fafe351764)

7.อธิบายสิ่งที่พบในการทดลอง
