## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/8de3111f-8622-4fea-944a-c61da3fd69db)

- ไม่สามารถ Build ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ private

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/ad9d3dc0-55df-4cb7-be0c-2805b98dc7c8)

- ไม่สามารถ Run ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ เพราะเป็น  private

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 

- This is some shape with 0 sides
- This is a circle
- This is some shape with 4 sides
- This is a rectangle
- This is a triangle

## หลังแก้ไขโปรแกรม
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/c61eb02f-6f4d-46b2-b7f2-b5608c9a350f)
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/e19f521e-9517-4142-8a50-3314cec9df70)



- ในกรณีนี้ ผมเพิ่มพารามิเตอร์ isSpecial เพื่อสร้างเงื่อนไขพิเศษหากต้องการจัดการรูปร่างบางแบบโดยเฉพาะ ในกรณีที่ไม่จำเป็นสามารถละเว้นพารามิเตอร์นี้ได้โดยใช้ constructor ที่ไม่มีพารามิเตอร์เพิ่มเติมในคลาส Shape แทน และเรียกใช้ base( ) ในคลาสลูกตามที่แสดงในคลาส Triangle ในที่นี้ในการสร้างวงกลม สี่เหลี่ยม และสามเหลี่ยม โดยลำดับ
