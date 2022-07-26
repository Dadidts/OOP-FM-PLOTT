using _6_Lesson.Lesson61.Infrastructure;
using Bank;

namespace _6_Lesson;

internal class DZ1
{

    const string date_file_path = @"C:\Users\Стас\Desktop\!LS_GB\OOP\6_Lesson\Lesson6-1\Infrastructure\BaseClient.txt";

    internal static void SolHomeWorck1()
    {

        bool flag = true;

        Console.Clear();
        while (flag)
        {
            //Меню выбора решения
            Console.Clear();
            Console.WriteLine("1- Создать базу клиентов из файла, открыть счета каждому клиенту и зачислить на остаток: ");
            Console.WriteLine("2- Печать (Вывод на экран) базы клиентов(ID, ФИО, номер счета, тип счета, остаток: ");
            Console.WriteLine("3- Сравнить 2 аккаунта (клиент, счет, баланс) (рандомных или указанных пользователем по id клиенту): ");
            Console.WriteLine("0- выход из программы:");

            int numMenu = NumbersMenu.Numbers("Выберите действие: ");
            //Конец меню

            //Выбор решения задания
            switch (numMenu)
            {
                case 0:
                    {

                        Console.Clear();
                        Console.WriteLine("Программа завершена.");
                        break;

                    }
                case 1:
                    {

                        Console.Clear();
                        CASE1();
                        Console.WriteLine("BASE CLIENT BANK CREATE.");
                        Console.ReadLine();

                        break;

                    }
                case 2:
                    {

                        Console.Clear();
                        CASE2();
                        Console.ReadLine();

                        break;

                    }
                case 3:
                    {

                        Console.Clear();
                        CASE3();
                        Console.ReadLine();

                        break;
                    }

                default:
                    {
                        Console.WriteLine("Вы ввели неверный номер задачи. Укажите верный порядковый номер задачи.");
                        break;
                    }
            }

            //Конец выбора заадния
            //Условия для выхода из программы
            if (numMenu == 0)
            {
                return;
            }

        }


        Console.ReadLine();

    }

    public static void CASE1()
    {

        var date_file = MeFile.FunctionRead(date_file_path);

        foreach (var line in date_file.EnumLines())
        {

            var client = BaseClient.ParseFile(line);
            var accountClient = BaseClient.NewAccountClient(client);

        }


    }

    public static void CASE2()
    {

        AccountClient.PrintAll();

    }

    public static void CASE3()
    {

        Console.WriteLine("Сравнить рандомные 2 счета или вы введете ID для сравнения самомстоятельно?:");
        Console.WriteLine("1: - рандомные 2 счета");
        Console.WriteLine("2: - введете ID для сравнения");
        int numMenu = NumbersMenu.Numbers("Выберите действие: ");

        switch (numMenu)
        {
            case 0:
                {

                    Console.Clear();
                    Console.WriteLine("Выйти в верхнее меню");
                    break;

                }
            case 1:
                {

                    Console.Clear();
                    CASE31();

                    Console.ReadLine();

                    break;

                }
            case 2:
                {
                    Console.Clear();
                    CASE32();

                    Console.ReadLine();

                    break;

                }
            default:
                {

                    Console.WriteLine("Вы выбрали неверное действие. Прочтите внимательно еще раз и выберите действие: ");
                    break;
                }
        }

        if (numMenu == 0)
        {
            return;
        }

    }
   
    public static void CASE31()
    {

        int acc1 = NumbersMenu.NewRandom(0, 149);
        int acc2 = NumbersMenu.NewRandom(0, 149);

        PrintConsole(acc1, acc2);

    }

    public static void CASE32()
    {
        int [] arrayId = new int[2];

        for(int i=0; i < 2; i++)
        {
            int num = NumbersMenu.Numbers("Введите номер ID клиента, для сравнения информации с другим клиентом банка (Значение ID от 0 до 147): ");
            arrayId[i] = num; 

        }

        int acc1 = arrayId[0];
        int acc2 = arrayId[1];

        PrintConsole(acc1, acc2);

    }

    public static void PrintConsole(int acc1, int acc2)
    {

        var account1 = AccountClient.SearchAcc(acc1);
        var account2 = AccountClient.SearchAcc(acc2);

        Console.WriteLine($" Сравнение переопределенным методом Equals 2 счета:");
        Console.WriteLine($"{account1}");
        Console.WriteLine($"  и ");
        Console.WriteLine($"{account2}. ");
        Console.WriteLine($"Результат: {account1.Equals(account2)} ");

        //Вот тут не очень понятно, как вывести значение и как их сравнить
        Console.WriteLine($" ХэшКод первого счета: {account1.GetHashCode}");
        Console.WriteLine($" ХэшКод второго счета: {account2.GetHashCode}");

    }

}
