## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-12.png)

- ไม่สามารถ Build ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ private

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

- ไม่สามารถ Run ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ เพราะเป็น  private

![pic](/Pictures/pic-13.png)

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 

- This is some shape with 0 sides
- This is a circle
- This is some shape with 4 sides
- This is a rectangle
- This is a triangle

## หลังแก้ไขโปรแกรม

![pic](/Pictures/pic-16.png)

![pic](/Pictures/pic-14.png)

![pic](/Pictures/pic-15.png)

- แก้ไข private int? NumOfSide กับ private Shape() เป็น public int? NumOfSide public Shape

- this() จะเป็นการเรียก Constructor ที่ไม่มีพารามิเตอร์ หรือ Constructor ที่รับพารามิเตอร์อื่นๆ ในคลาสเดียวกัน โดยการใช้ this() เราสามารถลดการทำงานซ้ำซ้อนใน Constructor ของคลาสได้