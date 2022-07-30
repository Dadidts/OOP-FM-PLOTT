
namespace _6_Lesson.Lesson62;

internal class Point : Figure
{

    private int _x;
    private int _y;

    private char _symb;
      


    public int x { get => _x; set => _x = value; }
    public int y { get => _y; set => _y = value; }
    public ConsoleColorEnum ConsoleFigure { get => _ColorFigure; set => _ColorFigure = value; }
    public char symb { get => _symb; set => _symb = value; }


    internal Point()
    {

    }
    internal Point(int x, int y, char symb)
    {

        _x = x;
        _y = y;
        _symb = '*';

    }

    internal void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symb);
    }

    protected override double Square()
    {

        double sqr = 1;
        return sqr;

    }

    protected override double Square(double x)
    {
        return x;
    }
    protected override double Square(double x, double y)
    {
        return x;
    }
    internal ConsoleColorEnum ColorSelection()
    {
        ConsoleColorEnum ConsoleFigure = ConsoleColorEnum.White;

        return ConsoleFigure;
    }

    public override string ToString()
    {
        return string.Format($"Точка: x{_x}, y {_y}, symb {_symb}");
    }

    

    protected void Move(int move, Direction direction)
    {
        switch (direction)
        {
            case Direction.LEFT:
                {

                    foreach (Point point in pList)
                    {
                        point.x = point.x - move;
                    }

                    break;

                }
            case Direction.RIGHT:
                {

                    foreach (Point point in pList)
                    {
                        point.x = point.x + move;
                    }

                    break;

                }
            case Direction.DOWN:
                {

                    foreach (Point point in pList)
                    {
                        point.y = point.y - move;
                    }

                    break;

                }
            case Direction.UP:
                {
                    foreach (Point point in pList)
                    {
                        point.y = point.y + move;
                    }

                    break;
                }
        }

    }



}
