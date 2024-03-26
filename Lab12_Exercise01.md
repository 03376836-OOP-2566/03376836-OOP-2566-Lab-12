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

<img width="528" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-12/assets/144195963/70a399b4-0c20-403d-bab9-cdddcf190f1c">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="465" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-12/assets/144195963/44179a26-a9da-44e9-9d7c-f69db689fc8e">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Implementation of inheritance classes
