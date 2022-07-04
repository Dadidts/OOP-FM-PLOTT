using _2_Lesson.CBankOfRussia;
using _2_Lesson.CBankOfRussia2;

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
                Console.WriteLine("");

                Menu2();
                break;

            }
        case 3:
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                break;

            }
        case 4:
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
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


}