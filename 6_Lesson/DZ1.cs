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

    }





}
