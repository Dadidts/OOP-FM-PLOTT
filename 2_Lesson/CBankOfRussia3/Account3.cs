namespace _2_Lesson.CBankOfRussia3;

public class Account3
{
    //Поля
    private string Number;
    private string Client;
    private decimal Balance;
    private TypeAccount3 type;
    public static int SetNumber;
    //Конец

    //Конструкторы
    public Account3()
    {

    }

    //Конструктор для 3х полей (имя, тип, баланс)
    public Account3(string client, decimal balance, TypeAccount3 type)
    {
        Number = NewNumber();
        Client = client;
        Balance = balance;
        this.type = type;

    }

    //Конструктор для полей(имя, баланс)
    public Account3(string client, decimal balance)
    {
        Number = NewNumber();
        Balance = balance;

    }
    //Конструктор для полей(имя, тип)
    public Account3(string client, TypeAccount3 type)
    {
        Number = NewNumber();
        this.type = type;

    }
    //Конец

    //Методы
    public string GetNumber()
    {
        return Number;
    }
    public string GetClient()
    {
        return Client;
    }
    public decimal GetBalance()
    {
        return Balance;
    }
    public TypeAccount3 GetTypeAccount()
    {
        return type;
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
    public static TypeAccount3 Selection(int i)
    {
        //Выбор типа счета
        if (i == 1)
        {
            TypeAccount3 type = (TypeAccount3.DEBET);
            return type;

        }
        else if (i == 2)
        {
            TypeAccount3 type = (TypeAccount3.CREDIT);
            return type;

        }
        else if (i == 3)
        {
            TypeAccount3 type = (TypeAccount3.MIXED);
            return type;

        }
        return 0;
    
    }
    public void SetTypeAccountDebet(TypeAccount3 typeAccount)
    {

        type = TypeAccount3.DEBET;


    }
    public void SetTypeAccountCredit(TypeAccount3 typeAccount)
    {

        type = TypeAccount3.CREDIT;


    }
    public void SetTypeAccountMixed(TypeAccount3 typeAccount)
    {

        type = TypeAccount3.MIXED;


    }
    public void Print()
    {
        Console.WriteLine($"Клиенту: {Client} открыт счет №: {Number} Тип: {type} Баланс: {Balance} ");
    }
    //Конец

}
