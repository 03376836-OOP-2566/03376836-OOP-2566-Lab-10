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

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/6acb328b-2aeb-43ee-88d1-4ace59e73357)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/d1566e90-1893-4cef-a4a4-e078ab89896a)

## แก้ไข
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/8c7266ca-b36e-4951-8b2b-ae564c3f857f)
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/fb2b0b24-9d1d-4948-afc0-feb58f98c2b7)


7.อธิบายสิ่งที่พบในการทดลอง
- การที่ shapeบรรทัดที่8 เป็นprivateจะทำให้เข้าถึงได้จากคลาสลูกได้ต้องเปลี่ยนเป็นpublic จึงจะสามารถเข้าถึงหรืออาจจะใช้protected เพื่อสามารถเรียกใช้ constructor shape จากคลาสลูกได้
