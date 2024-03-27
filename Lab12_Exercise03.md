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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-12/assets/144195611/726802f3-85ad-4467-8a22-6c8a34f3b671)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-12/assets/144195611/dabb20f4-6d18-49a6-82e0-8f61fdf264a2)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ abstract class Animal และการสร้างอาร์เรย์ของ objects ของคลาสที่สืบทอดมาจาก Animal ซึ่งประกอบด้วย Dog, Fish, และ Bird
- ในแต่ละรอบของลูป foreach เรียกใช้เมทอด Move() ของแต่ละวัตถุภายในอาร์เรย์ animals
- เมทอด Move() เป็น abstract method ในคลาส Animal ดังนั้นจึงต้องมีการโอเวอร์ไรด์เมทอด Move() ในแต่ละคลาสที่สืบทอดมา 
