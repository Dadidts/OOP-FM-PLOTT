
namespace _6_Lesson.Lesson62;

internal class Circle : Figure
{
    
    private Point? _centr;

    private readonly double _radius;


    public Point centr { get => _centr; set => _centr = value; }
    public double radius => _radius;

    internal Circle(Point point, double radius)
    {

        pList = new List<Point>();
        pList.Add(point);
        _radius = radius;
        double a = 90 / _radius;
        double b = 360 / a;
        double temp = a;

        for (int i = 0; i <= b; i++)
        {

            pList.Add(PointPosition(point, radius, a));
            a = a + temp;

        }

    }

    internal Point PointPosition(Point point, double radius, double a)
    {

        var point1 = new Point(0, 0, '*');

        point1.x = (int)(point.x + radius * Math.Cos(a));
        point1.y = (int)(point.y + radius * Math.Sin(a));

        return point1;


    }
    protected override double Square(double radius)
    {
        double sqr=Math.PI*radius*radius;

        return sqr;
    }
    protected override double Square()
    {
        double x = 0;
        return x;
    }
    protected override double Square(double x, double y)
    {
        return x;
    }

    internal void Move()
    {

    }
}
