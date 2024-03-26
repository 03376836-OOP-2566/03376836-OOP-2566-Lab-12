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

![3](https://github.com/Siriratda/03376836-OOP-2566-Lab-12/assets/144195995/b858aae5-a89e-467b-9f08-aa9d5981e2cc)

สามารถ Build ได้ เพราะ ทุกคลาสสืบทอดมาจาก abstract class Animal ซึ่งไม่มีโครงสร้างการทำงาน แต่สืบทอดไป class อื่น ทำให้เกิด override ทำให้สามารถแสดงผลข้อมูลที่แตกต่างกันไปในแต่ละ class

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![3 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-12/assets/144195995/73173043-3249-46aa-a3e0-370c0fd08ca9)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ สืบทอดมาแล้ว เกิด override แต่ละ class มีการทำงานที่แตกต่างกันตามที่กำหนด

โปรแกรมจะแสดงผล

Dog: running on the ground

Fish: swimming in water

Bird: fly in the air
