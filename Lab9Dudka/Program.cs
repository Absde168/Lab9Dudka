class Parallelepiped
{
    private double length;
    private double width;
    private double height;
    public Parallelepiped()
    {
        length = 0;
        width = 0;
        height = 0;
    }
    public Parallelepiped(double l, double w, double h)
    {
        length = l;
        width = w;
        height = h;
    }
    ~Parallelepiped()
    {
        Console.WriteLine("Объект параллелепипеда уничтожен");
    }
    public double CalculateVolume()
    {
        return length * width * height;
    }
    public double CalculateDiagonal()
    {
        return Math.Sqrt(length * length + width * width + height * height);
    }
    public string GetInfo()
    {
        return $"Параллелепипед с длинами сторон: {length}, {width}, {height}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Parallelepiped p1 = new Parallelepiped(); 
        Parallelepiped p2 = new Parallelepiped(3, 4, 5);
        Console.WriteLine(p2.GetInfo());
        Console.WriteLine($"Объем параллелепипеда: {p2.CalculateVolume()}");
        Console.WriteLine($"Длина наибольшей диагонали параллелепипеда: {p2.CalculateDiagonal()}");
    }
}