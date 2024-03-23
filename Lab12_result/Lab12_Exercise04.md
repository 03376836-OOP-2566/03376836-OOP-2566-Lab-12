### ผลที่ได้จากการรันคำสั่งในข้อ 3

![Screenshot 2024-03-23 214807](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-12/assets/144195697/3fe03456-7884-4607-b388-a9f49a0cae1b)

โปรแกรม Build ได้เพราะมีการเรียกใช้เมท็อด CalculateArea() แต่ละคลาสเพื่อคำนวณพื้นที่ของรูปทรงต่าง ๆ

### ผลที่ได้จากการรันคำสั่งในข้อ 5

![Screenshot 2024-03-23 214810](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-12/assets/144195697/dadaf614-b8ba-4fb1-b41c-18b6ad4c74a3)

โปรแกรม Run ได้เพราะ Shape ประกาศเมท็อด CalculateArea() เป็น abstract ทำให้แต่ละคลาสลูกต้องโอเวอร์ไรด์เมท็อด CalculateArea() ตามลักษณะของรูปทรงนั้น ๆ

### สิ่งที่พบในการทดลอง
- โปรแกรม Build ได้เพราะมีการเรียกใช้เมท็อด CalculateArea() แต่ละคลาสเพื่อคำนวณพื้นที่ของรูปทรงต่าง ๆ และ Shape ประกาศเมท็อด CalculateArea() เป็น abstract ทำให้แต่ละคลาสลูกต้องโอเวอร์ไรด์เมท็อด CalculateArea() ตามลักษณะของรูปทรงนั้น ๆ
- ผลลัพท์ที่ได้ คือ
  - Rectangle Area = 10.00000 x 20.00000 = 200.00000 unit(s)
  - Triangle Area = 10.00000 x 20.00000 x 1/2  = 100.00000 unit(s)
  - Circle Area = 3.14159 x 10 ^2  = 314.15927 unit(s)


