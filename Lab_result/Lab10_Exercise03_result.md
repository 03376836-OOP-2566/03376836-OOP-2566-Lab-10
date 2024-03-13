## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/6a60b891-363a-4d76-802c-6aab88e3befa)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/db89a63e-0d72-4969-a0be-c3c98bca8431)

## อธิบายสิ่งที่พบในการทดลอง
### ในคลาส "Shape" มี Constructor ทั้งสองแบบ คือ
### 1.Constructor แรกไม่รับพารามิเตอร์ และแสดงข้อความ "This is some shape with unknown side"
### 2.Constructor ที่สองรับพารามิเตอร์จำนวนเลขของ (NumOfSide) และแสดงข้อความ "This is some shape with {NumOfSide} sides"
### ในคลาสลูก "Circle" มี Constructor ที่เรียก Constructor ของคลาสหลัก "Shape" โดยใช้ base() ซึ่งไม่รับพารามิเตอร์ และแสดงข้อความ "This is a circle"
### ในคลาสลูก "Rectangle" มี Constructor ที่เรียก Constructor ของคลาสหลัก "Shape" โดยใช้ base(4) เพื่อส่งค่า 4 เข้าไปในพารามิเตอร์ และแสดงข้อความ "This is a rectangle"
### ในคลาสลูก "Triangle" ก็เช่นเดียวกัน มี Constructor ที่เรียก Constructor ของคลาสหลัก "Shape" โดยใช้ base(3) เพื่อส่งค่า 3 เข้าไปในพารามิเตอร์และแสดงข้อความ "This is a triangle"
