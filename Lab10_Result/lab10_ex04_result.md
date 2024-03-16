## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/3079996e-af82-4616-ab22-fcf1b708d9d9)


- ไม่สามารถ Build ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ เพราะเป็น  private

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/fd6a6f0d-2099-4401-90f4-ea6bddcfc0b2)


- ไม่สามารถ Run ได้ เพราะ Shape.Shape() ไม่สามารถเข้าถึงได้ เพราะเป็น  private

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล

- This is some shape with unknown side
- This is a circle
- This is some shape with 4 sides
- This is a rectangle
- This is some shape with 3 sides
- This is a triangle

## หลังแก้ไขโปรแกรม

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/dec9261b-bd41-40aa-a054-edeca3b3d8d0)

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-10/assets/144197367/e6f59049-f3b6-446f-8dda-05cd1a2b82ef)

- เปลี่ยน private Shape() เป็น public Shape()
- เพื่อให้สามารถเข้าถึงได้ทำให้ NumOfSide เป็น protected เพื่ออนุญาตให้คลาสลูกเข้าถึงได้
แก้ไขตัวกำหนดสิทธิ์การเข้าถึงของตัวสร้างในคลาส Shape เพื่ออนุญาตให้คลาสลูกเรียกใช้
แสดงตัวอย่างการสร้างอ็อบเจกต์รูปร่างในเมทอด Main ของคลาส Program
