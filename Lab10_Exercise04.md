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
- เปลี่ยน private Shape() เป็น public Shape() เพื่อให้สามารถเข้าถึงได้
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/8d5782ef-639b-4bd7-b7bb-27cb6fff2370)
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/47487e7c-1957-4ca0-8ff8-ccc077061120)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/462eaaf1-7010-409d-a18d-65ac621c7dff)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/8fb3cd65-fa0f-4964-a214-51302fab0cbc)

7.อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

- This is some shape with unknown side
- This is a circle
- This is some shape with 4 sides
- This is a rectangle
- This is some shape with 3 sides
- This is a triangle
