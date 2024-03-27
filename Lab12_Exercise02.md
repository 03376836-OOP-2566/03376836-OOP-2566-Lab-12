# Lab 12 Exercise 2

## Abstract class

![alt text](./Pictures/image02.png)

1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex02
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Shape[] shapes = new Shape[3];
shapes[0] = new Rectangle();
shapes[1] = new Triangle();
shapes[2] = new Circle();

foreach (var shape in shapes)
{
    shape.Draw();
}

abstract class Shape
{
    public abstract void Draw();
}
class Rectangle: Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Draw a rectangle");
    }
}
class Triangle: Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Draw a triangle");
    }
}
class Circle: Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Draw a circle");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-12/assets/144195611/0d3c2acf-16a8-4bdb-97d9-a939713d5bc2)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-12/assets/144195611/1a7aa550-90ae-47b2-89c8-3408ece534d9)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ abstract class และการสร้างอาร์เรย์ของ objects ของคลาสที่สืบทอดมาจาก abstract class 
- เมทอด Draw() เป็น abstract method ในคลาส Shape จึงต้องมีการโอเวอร์ไรด์เมทอด Draw() ในแต่ละคลาสที่สืบทอดมา เมื่อโปรแกรมทำงาน การเรียกใช้เมทอด Draw() ในแต่ละวัตถุจะเรียกใช้เมทอด Draw() ที่ถูกโอเวอร์ไรด์ในคลาสที่เกี่ยวข้องจะแสดงข้อความ "Draw a rectangle", "Draw a triangle", "Draw a circle" ตามลำดับ
