# Lab 12 Exercise 3

## Abstract class

1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex03
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="647" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-12/assets/144195963/31c49fac-0a38-4163-ab4f-0cd863700575">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="497" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-12/assets/144195963/197a1472-469e-4b6b-9e55-911b7c163ccf">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล
Dog: running on the ground
Fish: swimming in water
Bird: fly in the ai
