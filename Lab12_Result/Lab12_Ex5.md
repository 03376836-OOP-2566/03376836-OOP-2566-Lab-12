# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-12/assets/144195683/56b8be49-76b2-437d-bd31-8343d9da938c)
```
สามารถ Build ได้ เพราะ ทุกคลาสสืบทอดมาจาก abstract class Shape ซึ่งไม่มีโครงสร้างการทำงาน แต่สืบทอดไป class อื่น ทำให้เกิด override ทำให้สามารถแสดงผลข้อมูลที่แตกต่างกันไปในแต่ละ class
protected double Area จะกำหนดให้สมาชิกนั้นสามารถเข้าถึงได้จากภายในคลาสเอง และจากคลาสที่สืบทอดมาจากคลาสนั้นได้ (subclasses) แต่ไม่สามารถเข้าถึงได้จากภายนอกคลาส (จากภายนอกคลาสหรืออ็อบเจกต์) โดยตรง
```
# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-12/assets/144195683/2ded651a-fe31-46a5-aa60-a0cedab2cc5b)
```
สามารถ Run ได้ เพราะ สืบทอดมาแล้ว เกิด override แต่ละ class มีการทำงานที่แตกต่างกันตามที่กำหนด
```
# อธิบาย # 
```
โปรแกรมจะแสดงผล
Rectangle Area = 10.00000 x 20.00000 = 200.00000 unit(s)
Triangle Area = 10.00000 x 20.00000 x 1/2 = 100.00000 unit(s)
Circle Area = 3.14159 x 10 ^2 = 314.15927 unit(s)
