# Lab 10 Exercise 5

## การเรียก constructor ด้วย keyword `this`

1.สร้าง console application project

```cmd
dotnet new console --name Lab10_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/8daec84c-005f-4c63-8cf8-77c1b2bc0973)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/22a90435-d03f-4c8a-a659-3835e0d7d3bc)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/94848140-cc0d-44cd-a905-94066399aa27)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab10_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/a80ba15c-5298-4d93-8d71-4650127a5a1d)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/a8b95f6c-a7c7-44ec-a483-be4c1a942041)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab10_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/8ef24e02-f28f-4e3f-b1d0-7e5031496f76)


ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/7edd7f81-bdb1-45ab-af9b-cdcc356bef77)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/e0d9d85a-45e4-405c-9963-94c5a853f13f)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/d42d89d2-ac10-4780-bf5e-4b1132a148f7)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-10/assets/144197034/4612eead-fa56-4fb3-bc58-98eac274dedb)


7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองโค้ดมีปัญหาตรงที่คอนสตรักเตอร์ของคลาส Triangle ไม่ได้ระบุพารามิเตอร์ที่จำเป็นต้องใช้เมื่อเรียกใช้งานคอนสตรักเตอร์ของ Shape ซึ่งเกิดข้อผิดพลาดเนื่องจากพารามิเตอร์ที่ต้องระบุคือจำนวนด้านของรูปร่าง ซึ่งควรระบุให้เหมาะสมกับลักษณะของรูปร่างนั้นๆ ในกรณีของรูปสามเหลี่ยม (Triangle) ควรระบุจำนวนด้านเป็น 3 ด้าน เมื่อทำการแก้ไขโค้ดจะได้ การทดลองนี้เรามีการสร้างคลาสที่เรียกว่า Shape ซึ่งเป็นคลาสหลักที่ถูกสืบทอดโดยคลาสอื่น ๆ ไป ซึ่งมีการใช้คอนสตรักเตอร์ในการสร้างอ็อบเจกต์ของคลาส Shape เพื่อระบุจำนวนด้านของรูปร่างแต่ละรูป และมีการสร้างคลาสย่อยที่สืบทอดจาก Shape เพื่อสร้างรูปร่างต่าง ๆ ได้แก่ วงกลม (Circle), สี่เหลี่ยมผืนผ้า (Rectangle), และ สามเหลี่ยม (Triangle) โดยแต่ละคลาสย่อยนี้จะเรียกใช้คอนสตรักเตอร์ของ Shape เพื่อระบุจำนวนด้านของรูปร่างตามที่เหมาะสม และในส่วนของการแสดงผลนั้น จะแสดงข้อความที่ระบุลักษณะของรูปร่างแต่ละรูปที่ถูกสร้างขึ้นด้วยวิธีการที่ได้รับการสืบทอดจาก Shape ในตอนนี้คือวงกลม (Circle), สี่เหลี่ยมผืนผ้า (Rectangle), และ สามเหลี่ยม (Triangle) ตามลำดับ ดังภาพด้านบน


