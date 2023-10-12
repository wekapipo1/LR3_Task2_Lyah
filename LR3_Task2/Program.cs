using System;
class Rhombus
{
    protected double x; //довжина сторони
    protected double degrees; //кут в градусах
    protected double radians; //кут в радіанах
    public Rhombus()
    {

    }
    public Rhombus(double x, double degrees) //конструктор
    {
        this.x = x;
        this.degrees = degrees;
        this.radians = degrees * Math.PI / 180.0; //переведення градусів в радіани
    }
    public void Print() //виведення на екран
    {
        Console.WriteLine($"\nДовжина сторони = {x} Kут = {degrees}");
    }
    public double Area_Rhombus() //площа ромба
    {
        return x * x * Math.Sin(radians);
    }
    public double Prmtr() //периметр ромба
    {
        return x * 4;
    }
}
class Square : Rhombus
{
    public Square(double x) //конструктор
    {
        this.x = x;
        degrees = 90;
        radians = degrees * Math.PI / 180.0;        
    }
    public double Area_Circle() //площа вписаного кола
    {
        double radius = x / 2;
        return Math.PI * Math.Pow(radius, 2);
    }
    public double Length() //довжина вписаного кола
    {
        return x * Math.PI;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Random o = new Random(); 
        for (int i = 0; i < 5; i++)
        {
            double side = o.Next(1, 10); //випадкова довжина сторони
            double angle = o.Next(1, 180); //випадковий кут в градусах
            if (angle != 90)
            {
                //об'єкт батьківського класу
                Rhombus rh = new Rhombus(side, angle);
                rh.Print();
                Console.WriteLine($"Ромб: площа = {rh.Area_Rhombus():F2} периметр = {rh.Prmtr()}");              
            }
            else
            {
                //об'єкт дочірнього класу
                Square sq = new Square(side);
                sq.Print();
                Console.WriteLine($"Квадрат: площа = {sq.Area_Rhombus():F2} периметр = {sq.Prmtr()}");
                Console.WriteLine($"Вписане коло: площа = {sq.Area_Circle():F2} довжина = {sq.Length():F2}");                
            }                        
        }
    }
}