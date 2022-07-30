using _6_Lesson.Lesson62;

namespace _6_Lesson;

internal class DZ2
{
    internal static void SolHomeWorck2()
    {
        int Width = 120;
        int Height = 30;



        Console.SetBufferSize(Width, Height);

        Console.Clear();

        var p = new Point(60, 15, '*');
        var p1 = new Circle(p, 10);
        var p2 = new Point(5, 5, '*');
        var p3 = new Rectangle(p2, 10, 5);


        p.Draw();
        p1.Draw();
        p3.Draw();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                p.HandliKey(keyInfo.Key);
                p1.HandliKey(keyInfo.Key);
                p3.HandliKey(keyInfo.Key);
            }

            p.();
            p1.Draw();
            p3.Draw();
        }





        Console.ReadLine();

    }

}
