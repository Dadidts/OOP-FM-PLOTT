using System.Collections.Generic;

namespace _3_Lesson.Lesson31;

public class Account
{
    
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
        Number = NewNumber();
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
    public decimal WithdrawalAccount(decimal sum)
    {
        while (Balance - sum < 0)
        {
            Console.WriteLine($"Сумма для снятия превышает остаток. Введите сумму нятия меньше или равную остатку по счету. Остаток по счету: {Balance}");
            Console.Write("Введите сумму для снятия: ");
            sum = decimal.Parse(Console.ReadLine());

        }

        return Balance = Balance - sum;
    }
    public string NewNumber()
    {
        Number = GeneratorNumner();
        return Number;

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
            num = num + temp.ToString();

        }
        return num;

    }
    //Метод публичный статичный. Для выбора типа счета. Как я до этого дошел не знаю. Этот енум тыкал как проклятый. Но 
    //кажется вроде бы начал по тихонечку понимать. До полного еще далеко, но что то...
    public static TypeAccount Selection(int i)
    {
        //Выбор типа счета
        if (i == 1)
        {
            TypeAccount type = (TypeAccount.DEBET);
            return type;

        }
        else if (i == 2)
        {
            TypeAccount type = (TypeAccount.CREDIT);
            return type;

        }
        else if (i == 3)
        {
            TypeAccount type = (TypeAccount.MIXED);
            return type;

        }
        return 0;

    }
    //мЕтод перевода
    public string TransferFromAccount(string number, decimal amount)
    {
        string str=" ";
        return str;
    }          

}


