
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
        double a = 360 / _radius;

        for (double i = 0; i <= a; i = i++)
        {

            pList.Add(PointPosition(point, radius, a));

        }

    }

    internal Point PointPosition(Point point, double radius, double a)
    {

        var point1 = new Point(0, 0, '*');

        point1.x = (int)(point.x + radius * Math.Cos(a));
        point1.y = (int)(point.y + radius * Math.Sin(a));

        return point;


    }
    protected override double Square()
    {
        throw new NotImplementedException();
    }
}
