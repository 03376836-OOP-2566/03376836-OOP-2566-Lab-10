# Lab 10 Exercise 5

## การเรียก constructor ด้วย keyword `this`

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex05
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
    }
    public Shape(int NumOfSide) : this()
    {
       this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides" );
    }
}
class Circle :Shape
{
    public Circle():base(0)
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
   public Triangle() : base( ) // Hint: add number of size as parameters
    {
        System.Console.WriteLine("This is a triangle");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง
- แก้ไข private int? NumOfSide กับ private Shape() เป็น public int? NumOfSide public Shape

- this() จะเป็นการเรียก Constructor ที่ไม่มีพารามิเตอร์ หรือ Constructor ที่รับพารามิเตอร์อื่นๆ ในคลาสเดียวกัน โดยการใช้ this() เราสามารถลดการทำงานซ้ำซ้อนใน Constructor ของคลาสได้
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/2eca49ee-73a3-4e43-88ab-588bf0e5fc38)
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/a7aaa5d8-4c86-4fe7-b400-a44d4d50fb53)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/dd2efe5e-f258-4c58-96a9-f8a0b4d5a158)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-10/assets/144195708/5f3e8043-21d9-4341-8c18-5ac433f4b7e6)

7.อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล 

- This is some shape with 0 sides
- This is a circle
- This is some shape with 4 sides
- This is a rectangle
- This is a triangle
