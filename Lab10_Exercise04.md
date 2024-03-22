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

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/a3e5cba8-d1b1-4672-8b7e-b22e6e62df46)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/2db2fd44-ecaa-41a7-9103-d1f2bbb6608e)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/6ce17644-bd2e-48d6-b641-15e23aa3c28d)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/4729c7b1-cf62-4739-bfb8-c9492976ac71)

7.อธิบายสิ่งที่พบในการทดลอง

ข้อผิดพลาดในโค้ดคือการสร้างคลาส Shape ที่มีคอนสตรักเตอร์สองแบบซึ่งทำให้เกิดข้อผิดพลาดเนื่องจากไม่สามารถสร้างอ็อบเจกต์จากคลาสที่มีคอนสตรักเตอร์ที่ประกาศเป็น private ได้ การเปลี่ยนคอนสตรักเตอร์เป็น public
เมื่อแก้ไขโค้ดแล้วจะได้ข้อมูลดังนี้ จะมีการสร้าง อ็อบเจกต์ของ Rectangle และ อ็อบเจกต์ของ Triangle 
เมื่อสร้างอ็อบเจกต์ของ Rectangle จะแสดงข้อความ "This is some shape with 4 sides" และ "This is a rectangle"
เมื่อสร้างอ็อบเจกต์ของ Triangle จะแสดงข้อความ "This is some shape with 3 sides" และ "This is a triangle"

