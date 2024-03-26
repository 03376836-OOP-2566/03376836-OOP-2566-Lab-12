# Lab 12 Exercise 1

## Abstract member
![alt text](./Pictures/image01.png)
1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex01
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-12/assets/144195708/7dc8f297-8b25-40fb-b14d-b491c94d4671)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-12/assets/144195708/db9fc0bf-03b5-4990-be0a-c133eee47299)

7.อธิบายสิ่งที่พบในการทดลอง
ผลลัพธ์ที่ได้คือ "Implementation of inheritance classes" เนื่องจาก BC เป็นอ็อบเจกต์ของ

DerivedClass และการเรียกใช้งาน BC.A() จะเรียกใช้งานเมธอด A() ที่ถูก override ใน DerivedClass 
