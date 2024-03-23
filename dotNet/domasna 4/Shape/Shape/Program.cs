Console.WriteLine("Hello, World!");

Circle circle = new Circle();
circle.radius = 3;
circle.getArea(3, 0);
circle.getPerimeter(3, 0);

Rectangle rectangle = new Rectangle();
Console.WriteLine("Enter the value for sideA of the rectangle: ");
rectangle.sideA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the value for sideB of the rectangle: ");
rectangle.sideB = int.Parse(Console.ReadLine());

rectangle.getArea(rectangle.sideA, rectangle.sideB);
rectangle.getPerimeter(rectangle.sideA, rectangle.sideB);
public class Shape 
{
    public string Name
    {
        get { return Name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Name cannot be null or empty.");
            }
            else
            {
                Console.WriteLine($"Setting Name to: {value}");
                Name = value;
            }
        }
    }
    public string Color
    {
        get { return Color; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Color cannot be null or empty.");
            }
            else
            {
                Console.WriteLine($"Setting Color to: {value}");
                Color = value;
            }
        }
    }
    public int Position { get; set; }
    public virtual void getArea (int x, int y)
    {
        Console.WriteLine("There is no special implementation for area.");

    }
    public virtual void getPerimeter (int x, int y)
    {
        Console.WriteLine("There is no special implementation for perimiter.");

    }
}
public class Rectangle : Shape
{
    public int sideA { get; set; }
    public int sideB { get; set; }
    public override void getArea (int x, int y)
    {
        int size = sideA * sideB;
        Console.WriteLine($"The area of the rectangle is: {size}");
    }
    public override void getPerimeter (int x, int y)
    {
        int perim = 2*(sideA +  sideB);
        Console.WriteLine($"The perimeter of the rectangle is: {perim}");
    }
}

public class Circle : Shape
{
    public int radius { get; set; }

    public override void getArea(int x, int y)
    {
        double size = Math.PI * radius * radius;
        Console.WriteLine($"The area of the circle is: {size}");
    }
    public override void getPerimeter(int x, int y)
    {
        double perim = 2 * radius * Math.PI; 
        Console.WriteLine($"The perimeter of the circle is: {perim}");
    }
}