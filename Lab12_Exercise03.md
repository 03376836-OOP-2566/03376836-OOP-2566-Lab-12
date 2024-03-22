# Lab 12 Exercise 3

## Abstract class

1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/46aa717e-f486-4f44-b24e-18c65617c924)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Fish();
animals[2] = new Bird();

foreach (var animal in animals)
{
    animal.Move();
}

abstract class Animal
{
    public abstract void Move();
}
class Dog: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: running on the ground");
    }
}
class Fish: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: swimming in water");
    }
}
class Bird: Animal
{
    public override void Move()
    {
        System.Console.WriteLine($"{this.GetType()}: fly in the air");
    }
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/08ea469a-a380-4a24-9cfd-70f89fc26111)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/05f5d392-bee7-4178-a317-bed39ad5aa72)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/29079ab1-722d-4dc0-a51a-5a4379d90f50)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/d66c7203-ea1d-4b23-bc27-abfa2f5ee9e3)

7.อธิบายสิ่งที่พบในการทดลอง
