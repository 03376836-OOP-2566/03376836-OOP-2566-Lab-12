# Lab 12 Exercise 1

## Abstract member
![alt text](./Pictures/image01.png)
1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex01
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/4c57778b-0b9f-4f10-92f9-fc324a18788b)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
BaseClass BC = new DerivedClass();
BC.A(); 

abstract class BaseClass
{
    abstract public void A();
}
class DerivedClass : BaseClass
{
    public override void A()
    {
        System.Console.WriteLine("Implementation of inheritance classes");
    }
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/bc7b0281-dbe4-43e9-a206-4fcb77652589)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/183c7ba0-dd10-45c2-8217-2ee5ac3ce649)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/2d6dd4d2-6f0c-417c-971e-aaff34716b12)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เรามีการสร้างคลาส BaseClass ซึ่งเป็นคลาสที่มีเมท็อดที่ถูกประกาศเป็น abstract ซึ่งหมายความว่าเมท็อด A() ต้องถูกสร้างขึ้นใหม่ในคลาสลูก และมีคลาส DerivedClass ที่สืบทอดจาก BaseClass ซึ่งมีการโอเวอร์ไรด์เมท็อด A() โดยมีการแสดงผลข้อความ "Implementation of inheritance classes" ในเมท็อด A() ของ DerivedClass ซึ่งเป็นการใช้งานพอลีมอร์ฟิซึ่ม และในการสร้างอ็อบเจกต์เราใช้ BaseClass เป็นชนิดของตัวแปรแต่ก็สร้างอ็อบเจกต์จาก DerivedClass และเรียกใช้เมท็อด A() ซึ่งจะแสดงผลลัพธ์ "Implementation of inheritance classes" จาก DerivedClass ซึ่งมีการแสดงผลดังภาพด้านบน
