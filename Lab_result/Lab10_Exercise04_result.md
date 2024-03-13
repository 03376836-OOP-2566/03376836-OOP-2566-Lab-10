## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/80fa0aa3-cf23-43fa-84ca-299bd488dd34)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/cfa8e352-a299-43a3-9f7f-4076a7bd882d)

## อธิบายสิ่งที่พบในการทดลอง
### Error เนื่องจากการประกาศ Constructor ในคลาส "Shape" เป็น private ซึ่งทำให้ไม่สามารถเข้าถึงได้จากคลาสลูก ("Circle", "Rectangle", "Triangle") ที่ต้องการใช้งาน Constructor นี้จากคลาสหลักได้
## หลังแก้ไขโค้ด โดย เปลี่ยนตรงบรรทัดที่ 8 `private Shape()` จาก private เป็น public
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-10/assets/144196505/88b15557-b3ed-45ca-a837-2e80c36c9b71)
