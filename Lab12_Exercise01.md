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

![1](https://github.com/Siriratda/03376836-OOP-2566-Lab-12/assets/144195995/c620cec9-e0ba-4d15-8dc5-ee10562c4a57)

สามารถ Build ได้ เพราะ เพราะสร้าง abstract class BaseClass เป็นสามาชิกของ Class หรือ Interface ที่ถูกนิยามโดยเฉพาะ แต่ไม่มีการสร้างการทำงาน แล้วสืบทอดไป class DerivedClass : BaseClass

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![1 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-12/assets/144195995/9352b8df-4588-4e6d-94f8-43f33c3d2bbf)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ DerivedClass สืบทอดจาก BaseClass เกิดการ override method A() ซึ่ง class DerivedClass : BaseClass มีการทำงานตามที่กำหนดให้ แสดงผล

โปรแกรมจะแสดงผล Implementation of inheritance classes
