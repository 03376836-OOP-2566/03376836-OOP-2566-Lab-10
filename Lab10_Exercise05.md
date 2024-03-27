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

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/310cf066-58bf-4f6c-a569-5766466534c4)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/8581db64-7c1d-4501-b6e8-41f0a7e2261b)

## จากการทดลองมีข้อผิดพลาด
## แก้ไข บรรทัดที่ 33
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/b41ca43a-1a04-4a8a-a30d-e906a44109d2)

![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-10/assets/144195611/e63513dd-bbf5-4248-834b-d8e0ce8fd972)

7.อธิบายสิ่งที่พบในการทดลอง
- การแก้ไขคือแก้ไขในคลาส triangle constructor ที่ยังไม่ส่งไปยังคลาสShape ซึ่งต้องส่งพารามิเตอร์ int Num0fside ต้องส่งจำนวนของด้านรูปสามเหลี่ยม
- เพิ่มค่า 3 ไปเป็นจำนวนของด้านรูปสามเหลี่บมเพื่อเรียกใช้งาน constructorของ class
