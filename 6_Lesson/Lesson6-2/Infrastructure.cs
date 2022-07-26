
namespace _6_Lesson.Lesson62;

internal class Infrastructure
{
    internal int Random(int x, int y)
    {
        var random = new Random();
        int rndPoint = random.Next(x, y);
        return rndPoint;

    }

}
