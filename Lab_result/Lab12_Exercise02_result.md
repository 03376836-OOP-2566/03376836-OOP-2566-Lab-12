## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-12/assets/144196505/e1ba4d22-15d1-4e90-b6e1-a20b1d14f2b2)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-12/assets/144196505/8e5d4923-aa55-4ca8-aaf3-8e887d18f991)

## อธิบายสิ่งที่พบในการทดลอง
### Shape[] shapes = new Shape[3]; คือการสร้าง array ของ Obj ที่มีชนิดเป็น Shape และเป็น abstract class จำนวน 3 ตัว
### foreach (var shape in shapes) จะเป็นการวนลูปทุก Obj ใน array
### เมื่อเรียกใช้ shape.Draw(); จะเรียกใช้เมทอด Draw() ใน Shape(abstract method) และถูก override ในคลาส Rectangle, Triangle, และ Circle ในลูปแต่ละรอบ ซึ่งจะแสดงผลลัพธ์ของการวาดรูปของแต่ละรูป
