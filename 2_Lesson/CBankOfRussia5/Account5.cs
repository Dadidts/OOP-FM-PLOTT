namespace _2_Lesson.CBankOfRussia5;

public class Account5
{
    //Поля
    private string _Number;
    private string _Client;
    private decimal _Balance;
    private TypeAccount5 _type;
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
    public TypeAccount5 type
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

    //Конструкторы
    public Account5()
    {

    }

    //Конструктор для 3х полей (имя, тип, баланс)
    public Account5(string client, decimal balance, TypeAccount5 type)
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
public static TypeAccount5 Selection(int i)
{
    //Выбор типа счета
    if (i == 1)
    {
        TypeAccount5 type = (TypeAccount5.DEBET);
        return type;

    }
    else if (i == 2)
    {
        TypeAccount5 type = (TypeAccount5.CREDIT);
        return type;

    }
    else if (i == 3)
    {
        TypeAccount5 type = (TypeAccount5.MIXED);
        return type;

    }
    return 0;

}
public void Print()
{
    Console.WriteLine($"Клиенту: {Client} открыт счет №: {Number} Тип: {type} Баланс: {Balance} ");
}

}


