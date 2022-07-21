using _6_Lesson.Lesson61;
using _6_Lesson.Lesson62;
namespace _6_Lesson;

internal class DZ
{
    //Начало решения задачи № 1
    internal void HomeWork1()
    {

        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №1. ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ReadLine();

        SolHomeWorck1();

    }
    //Начало решения задачи № 2
    internal void HomeWork2()
    {

        Console.WriteLine("Решение задачи №2. ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ReadLine();

        SolHomeWorck2();
    }

    internal void SolHomeWorck1()
    {
        
        Console.Clear();

        Console.ReadLine();

    }

    internal void SolHomeWorck2()
    {
        Console.Clear();
       
        Console.ReadLine();
    }
    private static int Numbers(string message)
    {
        do
        {
            Console.Write(message);
            string text = Console.ReadLine();
            int result;
            if (int.TryParse(text, out result))
            {
                return result;
            }
        }
        while (true);
    }

}