# Lab 12 Exercise 5

## Abstract class

1.สร้าง console application project

```cmd
dotnet new console --name Lab12_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/cae22a19-332b-4189-b6fa-f014f96df639)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var shapes = new Shape[3];
shapes[0] = new Rectangle(10, 20);
shapes[1] = new Triangle(10, 20);
shapes[2] = new Circle(10);

foreach (var shape in shapes)
{
    shape.CalculateArea();
} 
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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/945f64f1-518c-4876-9b55-6e1c994b3b52)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/50ba6b1d-4620-467a-98b9-2e5fb3774d05)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/b3e4dd02-5aa0-4782-97a9-77b4bb575a16)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab12_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/cac254c6-bdf3-44e4-b86a-594dfff0d482)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab12_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-12/assets/144197034/aa6b5983-fff7-4531-8728-e05f3a71d0f3)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เป็นการสร้างอาร์เรย์ของอ็อบเจกต์และใช้งานพอลีมอร์ฟิซึ่งมีโครงสร้างดังนี้

การสร้างอาร์เรย์ของอ็อบเจกต์ เราสร้างอาร์เรย์ของอ็อบเจกต์ Shape และกำหนดค่าให้แต่ละช่องของอาร์เรย์ด้วยอ็อบเจกต์ที่สร้างจากคลาส Rectangle, Triangle, และ Circle ตามลำดับ

การเรียกใช้งานเมทอด เราใช้ลูป foreach เพื่อเข้าถึงแต่ละอ็อบเจกต์ในอาร์เรย์และเรียกใช้งานเมทอด CalculateArea() บนแต่ละอ็อบเจกต์ เพื่อคำนวณและแสดงพื้นที่ของรูปทรงแต่ละรูปออกทางหน้าจอ

คลาส Shape และคลาสลูก: คลาส Shape เป็น abstract class ที่มีเมทอด abstract Draw() และ CalculateArea() ที่ต้องโอเวอร์ไรด์ในคลาสลูก ซึ่งแต่ละคลาสลูก (Rectangle, Triangle, Circle) จะมีการโอเวอร์ไรด์เมทอดเหล่านี้เพื่อระบุการวาดรูปทรงและการคำนวณพื้นที่ของแต่ละรูปทรงตามลำดับ จากภาพจะแสดงผลดังภาพด้านบน
