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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-12/assets/144195555/a94ad8c0-d6b5-408c-9ccf-8134023fa700)
### สามารถ Build ได้ เพราะ เพราะสร้าง abstract class BaseClass เป็นสามาชิกของ Class หรือ Interface ที่ถูกนิยามโดยเฉพาะ แต่ไม่มีการสร้างการทำงาน แล้วสืบทอดไป class DerivedClass : BaseClass
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-12/assets/144195555/8e468b86-1b19-49e9-b3a7-109ccd40989f)
### สามารถ Run ได้ เพราะ DerivedClass สืบทอดจาก BaseClass เกิดการ override method A() ซึ่ง class DerivedClass : BaseClass มีการทำงานตามที่กำหนดให้ แสดงผล
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล Implementation of inheritance classes
