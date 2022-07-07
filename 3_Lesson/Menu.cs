using _3_Lesson;
using _3_Lesson.Lesson31;
using System.Collections.Generic;

public class Menu
{
    private string name;
    private string number;
    private decimal balance;
    private TypeAccount type;
    private string search, search1;
    private decimal sum;
    bool res = true;

    public void Menu1()
    {
        
        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №1. Проверка метода перевода со счета на счет. ");
        Console.WriteLine("Заданны параметры по умолчанию: Имя клиента: Станислав; № счета: генерируется автоматически; тип счета: DEBET; баланс при открытии: 100.");
        Console.WriteLine("Данные по 2му клиенту заводятся с консоли пользователем ПО.");
        Console.WriteLine("Реализован множественный выбор действий: пополнение через кассу, перевод на счет, вывод коллекции на экран с подсчетом кол-ва и остатков на счету.");
        Console.WriteLine("==========================================================================================================");
        //Конец

        MenuMenu();

    }
    public void Menu2()
    {

        Console.WriteLine("Решение задачи №2. Переворот строки. //Проверка на полиндром.//");
        Console.WriteLine("Заданная строка по умолчанию: 'Ехал грека через реку'. Вторую строку пользователь вводит самостоятельно, при желании.");
        Console.WriteLine("==========================================================================================================");

    }
    public void Menu3()
    {

        Console.WriteLine("Решение Задачи №3. Работа со строкой. Задачка со *");
        Console.WriteLine("Дан текстовый файл содержащий: ФИО и e-mail. Разделитель &. Сформировать новый файл содержащий только список e-meil. Предусмотреть метод");
        Console.WriteLine("выделяющий из строки адрес почты. Метод в качестве параметра принимает строку (str), почта возвращается этой же строкой (str)");
        Console.WriteLine("==========================================================================================================");

    }
    public void MenuMenu()
    {

        //Данные 1го клиента. Значения по умолчанию.
        name = "Станислав";
        TypeAccount type = TypeAccount.DEBET;
        balance = 100;
        //Создаем клиента
        Account account = new Account(name, balance, type);

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
        bool f = true;


        while (f)
        {
            //Меню выбора решения
            Console.Clear();
            Console.WriteLine("Выбор действия:");
            Console.WriteLine("1 - Пополнение счет через кассу:");
            Console.WriteLine("2 - Перевод на счет другого клиента, со своего счета:");
            Console.WriteLine("3 - Печать клиентской базы:");
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
                        MenuMenu1();
                        break;

                    }
                case 2:
                    {
                        Account.PrintAllList();
                        MenuMenu2();
                        break;




                    }
                case 3:
                    {

                        Console.Clear();
                        MenuMenu3();;
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
    //Пополнение счета
    public void MenuMenu1()
    {
        name = "0";
        balance = 0;
        type = 0;
        Console.Write("Введите номер счета для пополнения: ");
        search = Console.ReadLine();
        Console.Write("Введите сумму пополнения счета: ");
        sum = decimal.Parse(Console.ReadLine());
        Account accountN1 = new Account(name, balance, type, number);
        accountN1 = accountN1.SearchList(accountN1, search);
        accountN1.ReplenishmentAccount(sum);
        Console.WriteLine($"Пополнение счета на сумму: {sum} осуществлено. Баланс счета составляет: {accountN1.Balance}");
        Console.ReadLine();

    }
    //Перевод со своего счета, на счет другого клиента
    public void MenuMenu2()
    {
        name = "0";
        balance = 0;
        type = 0;
        Console.Write("Введите номер счета с которого желаете осуществить перевод: ");
        search = Console.ReadLine();
        Account accountN1 = new Account(name, balance, type, number);
        accountN1 = accountN1.SearchList(accountN1, search);
        Console.Write("Введите номер счета на который желаете осуществить перевод: ");
        search1 = Console.ReadLine();
        Account accountN2 = new Account(name, balance, type, number);
        accountN2 = accountN2.SearchList(accountN2, search1);
        Console.Write("Введите сумму перевода: ");
        sum = decimal.Parse(Console.ReadLine());
        //Проверка на наличе средств на счете списания
        res = accountN1.TransferFrom(accountN1, sum);
        //Перевод сресдств со счета на счет
        if (res == true)
        {
            accountN1.TransferFromAccount(accountN1, accountN2, sum);
            Console.WriteLine("Транзакция выполнена успешно!");
            Console.WriteLine($"Остаток на счете списания: {accountN1.Number} составляет: {accountN1.Balance}.");
            Console.WriteLine($"Остаток на счете зачисления: {accountN2.Number} составляет: {accountN2.Balance}");
        }      
        else
        {

            Console.WriteLine($"Транзакция отменена. На счету недостаточно средств для осуществления перевода. Пополните счет и повторите операцию.");

        }
                      
        Console.ReadLine();

    }
    //Вывод на экран всей клиентской базы
    public void MenuMenu3()
    {

        Account.PrintAllList();
        Console.ReadLine();

    }
    //Решение 2й задачи переворот строки
    public void MenuMenu4()
    {
 

    }


}
