using _5_Lesson.Lesson51;
using _5_Lesson.Lesson52;
namespace _5_Lesson;

internal class DZ
{
    //Начало решения задачи № 1
    internal void HomeWork1()
    {

        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №1. ");
        Console.WriteLine("Создать класс рациональных чисел. В классе 2 поля: числитель и знаменатель. Предусмотреть конструктов. Определить");
        Console.WriteLine("операторы ==, != (метод Equals()), <,>, <=,>=, +,-,++,--. Переопределить метод ToString() для вывода дроби. Определить операторы");
        Console.WriteLine("преобразования типов между типом дробь, float, int. Определить операторы *, /, %.");
        Console.ReadLine();

        SolHomeWorck1();

    }
    //Начало решения задачи № 2
    internal void HomeWork2()
    {

        Console.WriteLine("Решение задачи №2. ");
        Console.WriteLine("Создать класс рациональных чисел. В классе 2 поля: числитель и знаменатель. Предусмотреть конструктов. Определить");
        Console.WriteLine("операторы ==, != (метод Equals()), <,>, <=,>=, +,-,++,--. Переопределить метод ToString() для вывода дроби. Определить операторы");
        Console.WriteLine("преобразования типов между типом дробь, float, int. Определить операторы *, /, %.");
        Console.ReadLine();

        SolHomeWorck2();
    }

    internal void SolHomeWorck1()
    {
        int x1, x2, y1, y2;
        Console.Clear();

        x1 = Numbers("Введите числитель первой дроби: ");
        y1 = Numbers("Введите знаменатель первой дроби: ");

        x2 = Numbers("Введите числитель второй дроби: ");
        y2 = Numbers("Введите знаменатель второй дроби: ");

        var a = new RationalNumber(x1, y1);
        var b = new RationalNumber(x2, y2);
        var res = new RationalNumber(0, 0);
        Console.WriteLine("Арифметические операции над дробями: Сложение, Вычетание, Умножение, Деление. Так же операции сравнения (==,!=,<,>,<=,>=.");

        Console.WriteLine("Сложение.");
        res = a + b;
        Console.WriteLine($"Сумма {a.ToString()} и {b.ToString()} равна: {res.ToString()}");

        Console.WriteLine("Вычетание.");
        res = b - a;
        Console.WriteLine($"Вычетание {a.ToString()} из {b.ToString()}  равно: {res.ToString()}");

        Console.WriteLine("Умножение.");
        res = a * b;
        Console.WriteLine($"Умножение {a.ToString()} на {b.ToString()}  равно: {res.ToString()}");

        Console.WriteLine("Деление.");
        res = b / a;
        Console.WriteLine($"Деление {b.ToString()} на {a.ToString()}  равно: {res.ToString()}");

        Console.ReadLine();

    }

    internal void SolHomeWorck2()
    {
        Console.Clear();
        int x1, x2, y1, y2;
        Console.Clear();

        x1 = Numbers("Введите вещественную часть первого комплексного числа: ");
        y1 = Numbers("Введите мнимую часть первого комплексного числа: ");

        x2 = Numbers("Введите вещественную часть второго комплексного числа: ");
        y2 = Numbers("Введите мнимую часть второго комплексного числа: ");

        var a = new ComplexNumber(x1, y1);
        var b = new ComplexNumber(x2, y2);
        var res = new ComplexNumber(0, 0);
        Console.WriteLine("Арифметические операции над комплексными числами: Сложение, Вычетание, Умножение.");

        Console.WriteLine("Сложение.");
        res = a + b;
        Console.WriteLine($"Сумма {a.ToString()} и {b.ToString()} равна: {res.ToString()}");

        Console.WriteLine("Вычетание.");
        res = b - a;
        Console.WriteLine($"Вычетание {a.ToString()} из {b.ToString()}  равно: {res.ToString()}");

        Console.WriteLine("Умножение.");
        res = a * b;
        Console.WriteLine($"Умножение {a.ToString()} на {b.ToString()}  равно: {res.ToString()}");


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