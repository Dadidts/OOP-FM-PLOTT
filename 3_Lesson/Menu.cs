using _3_Lesson;
using _3_Lesson.Lesson31;
using System.Collections.Generic;

public class Menu
{
    public void Menu1()
    {
        
        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №1. Проверка метода перевода со счета на счет. ");
        Console.WriteLine("Заданны параметры: Имя клиента: Станислав; № счета: генерируется автоматически; тип счета: DEBET; баланс при открытии: 100.");
        Console.WriteLine("Данные по 2му клиенту заводятся с консоли оператором ПО.");
        Console.WriteLine("Реализован множественный выбор действий: пополнение через кассу, перевод на счет, запрос на пополнение счета. Организованно доп меню.");
        Console.WriteLine("==========================================================================================================");
        //Конец

        //Данные 1го клиента. Значения по умолчанию.
        //Имя
        string name = "Станислав";
        //тип счета
        TypeAccount type = TypeAccount.DEBET;
        //Начальный баланс счета
        decimal balance = 100;
        //Создаем клиента
        Account account = new Account(name, balance, type);
        DBase.AddList(account);
         
        //Заполнение данных для второго клиента
        //имя
        Console.Write("Введите имя клиента: ");
        name = Console.ReadLine();
        //тип счета
        Console.Write("Выберите тип счета: 1 - Дебетовый; 2 - Кредитный, 3 - Универсальный ");
        int i = int.Parse(Console.ReadLine());
        type = Account.Selection(i);
        //Сумма первоначального взноса
        Console.Write("Введите сумму первоначального взноса счета: ");
        balance = decimal.Parse(Console.ReadLine());
        
        //Создаем 2го клиента
        Account account1 = new Account(name, balance, type);       
        DBase.AddList(account1);
        Console.WriteLine("==========================================================================================================");
        DBase.PrintAllList();
        Console.WriteLine("==========================================================================================================");
        Console.WriteLine("Для продолжения нажмите любую кнопку...");
        Console.ReadLine();

        MenuMenu1();

 

    }
    public void Menu2()
    {

        Console.WriteLine("Решение задачи №2. Переворот строки. //Проверка на полиндром.//");
        Console.WriteLine("Заданная строка по умолчанию: 'Ехал грека через реку'. Вторую строку пользователь вводит самостоятельно.");
        Console.WriteLine("==========================================================================================================");

    }
    public void Menu3()
    {

        Console.WriteLine("Решение Задачи №3. Работа со строкой. Задачка со *");
        Console.WriteLine("Дан текстовый файл содержащий: ФИО и e-mail. Разделитель &. Сформировать новый файл содержащий только список e-meil. Предусмотреть метод");
        Console.WriteLine("выделяющий из строки адрес почты. Метод в качестве параметра принимает строку (str), почта возвращается этой же строкой (str)");
        Console.WriteLine("==========================================================================================================");

    }

    public void MenuMenu1()
    {

        bool f = true;


        while (f)
        {
            //Меню выбора решения
            Console.Clear();
            Console.WriteLine("Выбор действия:");
            Console.WriteLine("1 - Пополнение счет через кассу:");
            Console.WriteLine("2 - Перевод на счет со своего счета:");
            Console.WriteLine("3 - Запрос пополнения счета с другого счета (при наличии средств на счете, перевод выполняется):");
            Console.WriteLine("0 - выход из программы:");

            int numMenu = int.Parse(Console.ReadLine());
            //Конец меню

            //Выбор решения задания
            switch (numMenu)
            {
                case 0:
                    {

                        Console.Clear();
                        Console.WriteLine("Выход в осовное меню.");
                        break;

                    }
                case 1:
                    {

                        Console.Write("Введите сумму пополнения счета: ");
                        decimal sum = decimal.Parse(Console.ReadLine());
                        Console.Write("Введите номер счета для пополнения: ");
                        string number = Console.ReadLine();

                        break;

                    }
                case 2:
                    {

                        Console.Clear();
                        Menu menu = new Menu();
                        menu.Menu2();
                        break;

                    }
                case 3:
                    {

                        Console.Clear();
                        Menu menu = new Menu();
                        menu.Menu3();
                        break;

                    }
                default:
                    {
                        Console.WriteLine();
                        break;
                    }
            }

            //Конец выбора действия
            //Условия для выхода из программы
            if (numMenu == 0)
            {
                return;
            }

        }


    }

}
