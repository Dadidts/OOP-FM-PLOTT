
namespace _6_Lesson.Lesson62;

/// <summary>
/// Класс абстрактный. Т.к. фигура это абстрактное понятие, не имеющее ничего, только эффимерные понятия: размеры, площадь и прочее.
/// У каждой фигуры все это высчитывается самостоятельно. Ну и если какой то метод объявляется абстракным, класс становится тоже абстрактным.
/// </summary>
abstract class Figure
{
    protected Direction direction;

    protected ConsoleColorEnum _ColorFigure = ConsoleColorEnum.White;
    protected bool _Status;

    protected List<Point> pList;

    /// <summary>
    /// Метод рисование фигуры
    /// </summary>
    internal void Draw()
    {

        foreach (Point point in pList)
        {
            point.Draw();
        }

    }

    /// <summary>
    /// Метод движения фигуры. Движени е происходит по 2м осям (верх, низ, лево, право). Движутся все точки +1. или -1. И перерисовываются.
    /// </summary>
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

    internal void HandliKey(ConsoleKey key)
    {
        switch (key)
        {
            case (ConsoleKey.LeftArrow):
                {
                    Direction direction = Direction.LEFT;
                    break;
                }
            case (ConsoleKey.RightArrow):
                {
                    Direction direction = Direction.RIGHT;
                    break;
                }
            case (ConsoleKey.UpArrow):
                {
                    Direction direction = Direction.UP;
                    break;
                }
            case (ConsoleKey.DownArrow):
                {
                    Direction direction = Direction.DOWN;
                    break;
                }
        }

    }


    protected abstract double Square(double x, double y);
    protected abstract double Square();
    protected abstract double Square(double x);





}
