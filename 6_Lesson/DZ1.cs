namespace _6_Lesson;
using _6_Lesson.Lesson61;

internal class DZ1
{
    internal static void SolHomeWorck1()
    {
        bool flag = true;

        Console.Clear();
        while (flag)
        {
            //Меню выбора решения
            Console.Clear();
            Console.WriteLine("1- Создать базу клиентов из файла(без открытия счета и зачисления на остаток: ");
            Console.WriteLine("2- Создать базу клиентов банка из файла (создать базу клиентов из файла, открыть счета каждому клиенту и зачислить на остаток: ");
            Console.WriteLine("3- Сравнить 2 аккаунта (клиент, счет, баланс) (рандомных или указанных пользователем по id клиенту): ");
            Console.WriteLine("0- выход из программы:");

            int numMenu = Numbers("Выберите действие: ");
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
                        DZ homeWork = new DZ();
                        homeWork.HomeWork1();
                        break;

                    }
                //case 2:
                //    {

                //        //Console.Clear();
                //        //DZ homeWork = new DZ();
                //        //homeWork.HomeWork2();
                //        //break;

                //    }
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
    public static int Numbers(string message)
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
