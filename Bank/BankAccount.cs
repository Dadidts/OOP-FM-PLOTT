namespace Bank;

internal class Account
{
    //Поля
    private readonly string _Number;
    private readonly string _Client;
    private decimal _Balance;
    private readonly TypeAccount _type;
    private static int SetNumber;


    //Свойства
    public string Number
    {
        get
        {
            return _Number;
        }
        
    }
    public string Client
    {
        get
        {
            return _Client;
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
        
    }
    

    //Конструкторы    

    //Конструктор для 3х полей (имя, тип, баланс)
    public Account(string client, decimal balance, TypeAccount type)
    {
        _Number = NewNumber();
        _Client = client;
        Balance = balance;
        _type = type;

    }

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
        _Number = GeneratorNumner();
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
            num = num + temp.ToString();//// !!!!!!

        }
        return num;

    }
    //Метод публичный статичный. Для выбора типа счета. Как я до этого дошел не знаю. Этот енум тыкал как проклятый. Но 
    //кажется вроде бы начал по тихонечку понимать. До полного еще далеко, но что то...

    public override string ToString()
    {
        return ToString("");
    }

}

internal enum TypeAccount
{
    DEBET = 1,
    CREDIT,
    MIXED

}