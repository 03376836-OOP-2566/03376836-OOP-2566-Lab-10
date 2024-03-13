## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/3ffc0301-3819-4ac1-8731-244cfa2dd5d1)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/0c5b5e56-1ac8-4b63-af3b-7b010bdfa63f)

## อธิบายสิ่งที่พบในการทดลอง
### ในคลาส "Circle" มี Constructor ที่รับ NumOfSide เป็น 0 และเรียก Constructor อื่นในคลาสเดียวกัน โดยใช้ this() เพื่อเรียก Constructor แรกของคลาส "Shape" และจากนั้นแสดงข้อความ "This is a circle"
### ในคลาส "Rectangle" มี Constructor ที่รับ NumOfSide เป็น 4 และเรียก Constructor อื่นในคลาสเดียวกัน โดยใช้ this() เพื่อเรียก Constructor แรกของคลาส "Shape" และจากนั้นแสดงข้อความ "This is a rectangle"
### ในคลาส "Triangle" ไม่มีการรับค่า NumOfSide แต่เรียก Constructor อื่นในคลาสเดียวกัน โดยใช้ this() เพื่อเรียก Constructor แรกของคลาส "Shape" และจากนั้นแสดงข้อความ "This is a triangle"

## หลังแก้ไขโค้ด โดยการเปลี่ยนบรรทัดจาก private Shape() เป็น protected/public Shape()
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/976f62c9-9027-44e6-bd2c-8a07e679fce5)
