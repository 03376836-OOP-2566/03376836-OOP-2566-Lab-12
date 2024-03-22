# Lab 12 Exercise 4

## Abstract class

1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/40ec53b6-7cd7-480e-ade5-3ae66a941dcd)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/492235fc-2813-452e-a040-20e1bf78e1cb)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/d00070a9-bb5e-4a5c-9db2-a54251c59d8b)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/98cb5e7b-180c-434f-b711-8594003c9826)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/d515000f-f0ae-4310-947f-d2ac552c73f8)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/3243c4a4-40a7-4fd3-add0-91d1bd090d55)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/140e4109-2872-4d2e-83cd-a39b7949b294)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เป็นการสร้างและใช้งานคลาสและอ็อบเจกต์ในภาษา C# เพื่อคำนวณพื้นที่ของรูปทรงที่แตกต่างกัน โดยมีโครงสร้างดังนี้

คลาส Shape: เป็น abstract class ที่มีเมทอด abstract Draw() และ CalculateArea() ซึ่งไม่มีการนิยามเนื้อหา เป็นแค่แนวทางในการให้คลาสลูกๆ โอเวอร์ไรด์เมทอดเหล่านี้ตามลำดับการทำงานของแต่ละรูปทรง

คลาส Rectangle, Triangle, Circle: คลาสลูกทั้งสามนี้ได้โอเวอร์ไรด์เมทอด Draw() เพื่อนำเสนอข้อความที่บอกถึงการวาดรูปทรง และเมทอด CalculateArea() เพื่อคำนวณพื้นที่ของแต่ละรูปทรงตามลำดับ

การสร้างอ็อบเจกต์และการเรียกใช้งาน: ใน Main method เราสร้างอ็อบเจกต์ของคลาส Rectangle, Triangle, และ Circle แล้วกำหนดพารามิเตอร์ที่เหมาะสมตามลำดับ จากนั้นเราเรียกใช้เมทอด CalculateArea() บนแต่ละอ็อบเจกต์เพื่อคำนวณพื้นที่ของรูปทรงและแสดงผลลัพธ์ที่ได้ในรูปแบบของข้อความที่แสดงพื้นที่ของแต่ละรูปทรงออกทางหน้าจอ
