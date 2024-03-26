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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-10/assets/144195555/c3f822e3-217e-4b7e-a160-875334dfea95)
### สามารถ Build ได้ เพราะ เป็นการสร้าง Constructors คลาสมีลักษณะเดียวกับการสร้างเมทอดแต่มีชื่อเดียวกับชื่อคลาส โดยไม่มีการระบุประเภทข้อมูลเป็นตัวส่งพารามิเตอร์
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-10/assets/144195555/df29fc5d-cd17-4194-a88a-3cf020d22b61)
### สามารถ Run ได้ เพราะ สามารถระบุ Constructor ของแต่ละคลาสได้ตามลำดับที่ถูกเรียกใช้งานโดยอ็อบเจคต์
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### This is some shape
### This is a circle
### This is a rectangle
### This is a triangle
