﻿using _2_Lesson.CBankOfRussia;
using _2_Lesson.CBankOfRussia2;
using _2_Lesson.CBankOfRussia3;
using _2_Lesson.CBankOfRussia4;

bool f = true;


while (f)
{
    //Меню выбора решения
    Console.Clear();
    Console.WriteLine("Выберите решение задачи:");
    Console.WriteLine("1- первый вариант:");
    Console.WriteLine("2- второй вариант:");
    Console.WriteLine("3- третий вариант:");
    Console.WriteLine("4- четвертый вариант:");
    Console.WriteLine("0- выход из программы:");

    int numMenu = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Решение задачи №1.");
                Console.WriteLine("Заданны параметры: Имя клиента: Станислав; № счета: 408172539; тип счета: DEBET; баланс при открытии: 100.");
                Console.WriteLine("Данные по 2му клиенту заводятся с консоли оператором ПО.");
                Console.WriteLine("==========================================================================================================");

                Menu1();
                break;

            }
        case 2:
            {
                Console.Clear();
                Console.WriteLine("Решение задачи №2.");
                Console.WriteLine("Заданны параметры: отсутствуют.");
                Console.WriteLine("==========================================================================================================");

                Menu2();
                break;

            }
        case 3:
            {
                Console.Clear();
                Console.WriteLine("Решение Задачи №3.");
                Console.WriteLine("Заданны параметры: Имя клиента: Станислав; № счета: (открывается автоматически); тип счета: DEBET; баланс при открытии: 100.");
                Console.WriteLine("Заданны параметры: Имя клиента: Владимир; № счета: (открывается автоматически); тип счета: 0; баланс при открытии: 500.");
                Console.WriteLine("Заданны параметры: Имя клиента: Михаил; № счета: (открывается автоматически); тип счета: универсальный; баланс при открытии: 0.");
                Console.WriteLine("Данные по остальным клиентам заводятся с консоли оператором ПО.");
                Console.WriteLine("==========================================================================================================");
                Menu3();
                break;

            }
        case 4:
            {
                Console.Clear();
                Console.WriteLine("Решение Задачи №4.");
                Console.WriteLine("Заданны параметры: Имя клиента: Станислав; № счета: (открывается автоматически); тип счета: DEBET; баланс при открытии: 100.");
                Console.WriteLine("==========================================================================================================");
                Menu4();
                break;

            }
        case 5:
            {
                Console.Clear();
                Console.WriteLine("Решение Задачи №4.");
                Console.WriteLine("==========================================================================================================");
                Menu4();
                break;

            }
        default:
            {
                Console.WriteLine();
                break;
            }
    }
           
    //Конец выбора заадния
    
    if (numMenu == 0)
    {
        return;
    }

}

Console.WriteLine("");
Console.ReadLine();


void Menu1()
{ 
    
    //Задание 1 клиента программно
    Account1 account1 = new Account1();
    account1.SetClient("Станислав");
    account1.SetNumber(408172539);
    account1.SetTypeAccountDebet(TypeAccount.DEBET);
    account1.SetBalance(100);
    
    //Задание с консоли 2го клиента
    Account1 account2 = new Account1();
    Console.WriteLine("Введите имя клиента: ");
    account2.SetClient(Console.ReadLine());
    Console.WriteLine("Выберите тип счета: 1-Дебетовый; 2-Кредитный, 3-Универсальный");
    int i = int.Parse(Console.ReadLine());
    
    //Выбор типа счета

    if (i == 1)
    {
        account2.SetTypeAccountDebet(TypeAccount.DEBET);
    }
    else if (i == 2)
    {
        account2.SetTypeAccountCredit(TypeAccount.CREDIT);
    }
    else if (i == 3)
    {

        account2.SetTypeAccountMixed(TypeAccount.MIXED);

    }
    

    Console.WriteLine("Придумайте номер счета: ");
    account2.SetNumber(ulong.Parse(Console.ReadLine()));
    Console.WriteLine("Введите первоначальную сумму счета: ");
    account2.SetBalance(decimal.Parse(Console.ReadLine()));

    //Вывод результата

    account1.Print();
    Console.WriteLine("=================================================");
    account2.Print();
    Console.WriteLine("=================================================");
    Console.WriteLine("Проверка работы методов вызова свойств экземпляра класса.");
    Console.WriteLine("=================================================");
    Console.Write("Проверка работы методов Get: Баланс 1а счета: ");
    Console.WriteLine(account1.GetBalance());
    Console.Write("Проверка работы методов Get: Номер 2го счета: ");
    Console.WriteLine(account2.GetNumber());
    Console.Write("Проверка работы методов Get: Имя владельца 1го счета: ");
    Console.WriteLine(account1.GetClient());
    Console.Write("Проверка работы методов Get: Тип 2го счета: ");
    Console.WriteLine(account2.GetTypeAccount());
    Console.ReadLine();
    //Конец вывода результата

}
void Menu2()
{

    Account2 account = new Account2();
    Console.WriteLine("Введите имя клиента: ");
    account.SetClient(Console.ReadLine());
    Console.WriteLine("Выберите тип открываемого счета: 1-Дебетовый; 2-Кредитный, 3-Универсальный");
    int i = int.Parse(Console.ReadLine());

    //Выбор типа счета
    if (i == 1)
    {
        account.SetTypeAccountDebet(TypeAccount1.DEBET);
    }
    else if (i == 2)
    {
        account.SetTypeAccountCredit(TypeAccount1.CREDIT);
    }
    else if (i == 3)
    {

        account.SetTypeAccountMixed(TypeAccount1.MIXED);

    }

    Console.WriteLine("Введите вносимую сумму на счет: ");
    account.SetBalance(decimal.Parse(Console.ReadLine()));
    account.NewNumber();
    account.Print();
    Console.Write("Проверка работы методов Get для номера счета. Номер счета клиента : ");
    Console.WriteLine(account.GetNumber());
    Console.ReadLine();

}
void Menu3()
{
    //Значения полей по умолчанию. Используется конструктор для полей (имя, тип, баланс)
    string name = "Станислав";
    decimal balance = 500;
    TypeAccount3 type = TypeAccount3.DEBET;
    Account3 account = new Account3(name, balance, type);
    //Конец

    //Ввод с консоли значения полей. Используется конструктор для полей (имя, тип, баланс)
    Console.WriteLine("Работа конструктора с полями: ИМЯ, ТИП СЧЕТА, БАЛАНС");
    Console.WriteLine("====================================================");
    Console.WriteLine("Введите имя клиента: ");
    name = Console.ReadLine();
    Console.WriteLine("Выберите тип открываемого счета: 1-Дебетовый; 2-Кредитный, 3-Универсальный");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Сумма первоначального взноса: ");
    balance = decimal.Parse(Console.ReadLine());
    type = Account3.Selection(i);
    Account3 account1 = new Account3(name, balance, type);
    //Конец

    //Значения полей по умолчанию. Используется конструктор для полей (имя, баланс)
    name = "Владимир";
    balance = 500;
    Account3 account2 = new Account3(name, balance);
    //Конец

    //Ввод с консоли значения полей. Используется конструктор для полей (имя, баланс)
    Console.WriteLine("Работа конструктора с полями: ИМЯ, БАЛАНС");
    Console.WriteLine("====================================================");
    Console.WriteLine("Введите имя клиента: ");
    name = Console.ReadLine();
    Console.WriteLine("Сумма первоначального взноса: ");
    balance = decimal.Parse(Console.ReadLine());
    Account3 account3 = new Account3(name, type);
    //Конец

    //Значения полей по умолчанию. Используется конструктор для полей (имя, тип)
    name = "Михаил";
    type = TypeAccount3.MIXED;
    Account3 account4 = new Account3(name, type);
    //Конец

    //Ввод с консоли значения полей. Используется конструктор для полей (имя, тип)
    Console.WriteLine("Работа конструктора с полями: ИМЯ, ТИП СЧЕТА");
    Console.WriteLine("====================================================");
    Console.WriteLine("Введите имя клиента: ");
    name = Console.ReadLine();
    Console.WriteLine("Выберите тип открываемого счета: 1-Дебетовый; 2-Кредитный, 3-Универсальный");
    i = int.Parse(Console.ReadLine());
    type = Account3.Selection(i);
    Account3 account5 = new Account3(name, balance, type);
    //Конец

    //Вывод на консоль результата
    Console.WriteLine("ВЫВОД НА КОНСОЛЬ РЕЗУЛЬТАТА РАБОТЫ ПРОГРАММЫ:");
    account.Print();
    Console.WriteLine("====================================================");
    account1.Print();
    Console.WriteLine("====================================================");
    account2.Print();
    Console.WriteLine("====================================================");
    account3.Print();
    Console.WriteLine("====================================================");
    account4.Print();
    Console.WriteLine("====================================================");
    account5.Print();
    Console.ReadLine();

}
void Menu4()
{
    //Значения полей по умолчанию. Доступ к полям через свойства
    string name = "Станислав";
    decimal balance = 500;
    TypeAccount4 type = TypeAccount4.DEBET;
    Account4 account = new Account4(name, balance, type);
    //Конец

    //Ввод с консоли значения полей. Доступ к полям через свойства
    Console.WriteLine("Заполнение полей экземпляра класса через свойства");
    Console.WriteLine("====================================================");
    Console.WriteLine("Введите имя клиента: ");
    name = Console.ReadLine();
    Console.WriteLine("Выберите тип открываемого счета: 1-Дебетовый; 2-Кредитный, 3-Универсальный");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Сумма первоначального взноса: ");
    balance = decimal.Parse(Console.ReadLine());
    type = Account4.Selection(i);
    Account4 account1 = new Account4(name, balance, type);
    //Конец

    //Вывод на консоль результата
    Console.WriteLine("ВЫВОД НА КОНСОЛЬ РЕЗУЛЬТАТА РАБОТЫ ПРОГРАММЫ:");
    account.Print();
    Console.WriteLine("====================================================");
    account1.Print();
    Console.ReadLine();
    //Конец



}