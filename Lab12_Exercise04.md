# Lab 12 Exercise 4

## Abstract class

1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex04
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var rec = new Rectangle(10, 20);
rec.CalculateArea();

var tri = new Triangle(10, 20);
tri.CalculateArea();

var cir = new Circle(10);
cir.CalculateArea();

abstract class Shape
{
    protected double Area;
    public abstract void Draw();
    public abstract void CalculateArea();
}
class Rectangle : Shape
{
    double width, height;
    public override void Draw()
    {
        System.Console.WriteLine($"Draw a rectangle with area {Area}");
    }
    public Rectangle(double W, double H)
    {
        width = W;
        height = H;
    }
    public override void CalculateArea()
    {
        Area = width * height;
        System.Console.WriteLine($"{this.GetType()} Area = {width:F5} x {height:F5} = {Area:F5} unit(s)");
    }
}
class Triangle : Shape
{
    double Base, Height;
    public override void Draw()
    {
        System.Console.WriteLine("Draw a triangle");
    }
    public Triangle(double B, double H)
    {
        Base = B;
        Height = H;
    }
    public override void CalculateArea()
    {
        Area = Base * Height * 0.5;
        System.Console.WriteLine($"{this.GetType()} Area = {Base:F5} x {Height:F5} x 1/2  = {Area:F5} unit(s)");
    }
}
class Circle : Shape
{
    double Radius;
    public override void Draw()
    {
        System.Console.WriteLine("Draw a circle");
    }
    public Circle(double R)
    {
        Radius = R;
    }
    public override void CalculateArea()
    {
        Area = Math.PI * Radius * Radius;
        System.Console.WriteLine($"{this.GetType()} Area = {Math.PI:F5} x {Radius} ^2  = {Area:F5} unit(s)");
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-12/assets/144195995/bf675343-39a0-48fc-b049-07c825f4eb97)

สามารถ Build ได้ เพราะ ทุกคลาสสืบทอดมาจาก abstract class Shape ซึ่งไม่มีโครงสร้างการทำงาน แต่สืบทอดไป class อื่น ทำให้เกิด override ทำให้สามารถแสดงผลข้อมูลที่แตกต่างกันไปในแต่ละ class

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-12/assets/144195995/07a89a82-2617-413e-bab8-b1f1ec88402e)

7.อธิบายสิ่งที่พบในการทดลอง
สามารถ Run ได้ เพราะ สืบทอดมาแล้ว เกิด override แต่ละ class มีการทำงานที่แตกต่างกันตามที่กำหนด

โปรแกรมจะแสดงผล

Rectangle Area = 10.00000 x 20.00000 = 200.00000 unit(s)

Triangle Area = 10.00000 x 20.00000 x 1/2 = 100.00000 unit(s)

Circle Area = 3.14159 x 10 ^2 = 314.15927 unit(s)
