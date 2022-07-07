using System.Collections.Generic;

namespace _3_Lesson.Lesson31;

public class Account
{
    private static List<Account> accounts = new List<Account>();
    private static decimal s = 0;

    //Поля
    private string _Number;
    private string _Client;
    private decimal _Balance;
    private TypeAccount _type;
    public static int SetNumber;
    //Конец

    //Свойства
    public string Number
    {
        get
        {
            return _Number;
        }
        set
        {
            _Number = value;
        }
    }
    public string Client
    {
        get
        {
            return _Client;
        }
        set
        {
            _Client = value;
        }
    }
    public decimal Balance
    {
        get
        {
            return _Balance;
        }
        set
        {
            _Balance = value;
        }
    }
    public TypeAccount type
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }    
    //Конец
    
    //Конструктор для 3х полей (имя, тип, баланс, номер счета генерируется автоматически)
    public Account(string client, decimal balance, TypeAccount type)
    {
        Number = GeneratorNumner();
        Client = client;
        Balance = balance;
        this.type = type;
        accounts.Add(this);

    }
    public Account(string client, decimal balance, TypeAccount type, string number)
    {
        Number = number;
        Client = client;
        Balance = balance;
        this.type = type;

    }
    //Конец

    //Методы
    //Метод пополнения счета
    public decimal ReplenishmentAccount(decimal sum)
    {
        Balance = Balance + sum;
        return Balance;
    }
    public decimal WithdrawalTransfer(decimal sum)
    {
       
        Balance = Balance - sum;
        return Balance;

    }
    public string GeneratorNumner()
    {
        string num = "40817810";
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            int temp = random.Next(-1, 10);
            SetNumber = (random.Next(-1, 10));
            temp = (SetNumber * temp) / 2;
            if (temp < 0)
            {
                temp = 0;
            }
            else if (temp > 9)
            {
                temp = 1;
            }
            num += temp.ToString();

        }
        return num;

    }

    //Метод публичный статичный. Для выбора типа счета. Как я до этого дошел не знаю. Этот енум тыкал как проклятый. Но 
    //кажется вроде бы начал по тихонечку понимать. До полного еще далеко, но что то...
    public static TypeAccount Selection(int i)
    {
        //Выбор типа
        switch (i)
        {
            case 1:
                {
                    TypeAccount type = (TypeAccount.DEBET);
                    return type;

                }
            case 2:
                {
                    TypeAccount type = (TypeAccount.CREDIT);
                    return type;

                }
            case 3:
                {
                    TypeAccount type = (TypeAccount.MIXED);
                    return type;

                }
            default:
                {
                    TypeAccount type = (TypeAccount.MIXED);
                    return type;

                }

            
        }
        //Выбор типа счета
        //if (i == 1)
        //{
        //    TypeAccount type = (TypeAccount.DEBET);
        //    return type;

        //}
        //else if (i == 2)
        //{
        //    TypeAccount type = (TypeAccount.CREDIT);
        //    return type;

        //}
        //else if (i == 3)
        //{
        //    TypeAccount type = (TypeAccount.MIXED);
        //    return type;

        //}
        //else if (i != 1 && i != 2 && i != 3)
        //{
        //    TypeAccount type = (TypeAccount.MIXED);
        //    return type;

        //}
        //return 0;

    }
    //Метод перевода
    public bool TransferFromAccount(Account account, Account account1, decimal amount)
    {
        account.WithdrawalTransfer(amount);
        account1.ReplenishmentAccount(amount);
        return true;
    }
    public bool TransferFrom(Account account, decimal amount)
    {
        if(account.Balance-amount >= 0)
        {

            return true;
        }

        else
        {
            
            return false;
        };
    }
    
    
    //Статические методы по работе с листом.
    //Печать коллекции
    public static void PrintAllList()
    {
        Console.WriteLine($"По состоянию на {DateTime.Now}");
        s = 0;
        foreach (Account account in accounts)
        {
            
            Print(account);
            s += account.Balance;

        }
        Console.WriteLine("========================================================================================================================");
        Console.WriteLine($"В базе содержится {accounts.Count} записи(ей)");
        Console.WriteLine($"Всего на балансе денежных средств: {s}");

    }
    //отдельная печать одного клиента
    public static void Print(Account account)
    {

        Console.WriteLine($"Клиент:{account.Client} \t имеет счет №: {account.Number} Тип счета: {account.type}\t Остаток счета: {account.Balance} ");

    }
    //Поиск в коллекции
    public Account SearchList (Account account, string search)
    {

        for (int i = 0; i < accounts.Count; i++)
        {
            if(search == accounts[i].Number)
            {
                account = accounts[i];
                break;
            }
            
        }
        return account;
        
    }

}


