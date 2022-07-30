
namespace _6_Lesson.Lesson62;

internal class Rectangle : Figure
{
    private Point? _NullPoint;

    private readonly double _Perimetr;

    private int _Dlina;
    private int _Shirina;


    public Point NullPoint { get => _NullPoint; set => _NullPoint = value; }
    public double Perimetr => _Perimetr;
    public int Dlina { get => _Dlina; set => _Dlina = value; }
    public int Shirina { get => _Shirina; set => _Shirina = value; }

    internal Rectangle(Point? nullPoint, int dlina, int shirina)
    {
        NullPoint = nullPoint;
        _Perimetr = (dlina * shirina) * 2;
        Dlina = dlina;
        Shirina = shirina;

        PointPositionXY(nullPoint, dlina, shirina);

    }

    internal List<Point> PointPositionXY(Point? nullPoint, int dlina, int shirina)
    {
        pList = new List<Point>();
        pList.Add(nullPoint);
        
        




        for (int i = 0; i <= dlina; i++)
        {
            var p = new Point(0, nullPoint.y, nullPoint.symb);
            p.x = NullPoint.x + i;

            pList.Add(p);

        }
        for (int j = 0; j <= shirina; j++)
        {
            var p1 = new Point(NullPoint.x, 0, nullPoint.symb);
            p1.y = NullPoint.y + j;

            pList.Add(p1);

        }

        for (int k = 0; k <= dlina; k++)
        {
            var pointNullY = new Point(0, nullPoint.y + shirina, nullPoint.symb);

            pointNullY.x = nullPoint.x + k;

            pList.Add(pointNullY);

        }

        for (int l = 0; l <= shirina; l++)
        {
            var pointNullX = new Point(nullPoint.x + dlina, 0, nullPoint.symb);
            pointNullX.y = NullPoint.y + l;
            

            pList.Add(pointNullX);

        }

        return pList;

    }


    protected override double Square(double x, double y)
    {
        double res;
        res = x * y;

        return res;
    }
    protected override double Square()
    {

        double x = 0;
        return x;

    }
    protected override double Square(double x)
    {
        return x;
    }






}
