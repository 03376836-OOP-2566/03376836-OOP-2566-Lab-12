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

<img width="650" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-12/assets/144195963/38b42ecd-63b3-42cf-b087-cec98a464803">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="629" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-12/assets/144195963/55548543-1c75-47cb-9749-609450522040">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล
Draw a rectangle
Draw a triangle
Draw a circle
