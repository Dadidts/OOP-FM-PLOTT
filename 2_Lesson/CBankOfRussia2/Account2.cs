namespace _2_Lesson.CBankOfRussia2;

public class Account2
{
    private string Number;
    private string Client;
    private decimal Balance;
    private TypeAccount1 type;
    public static int SetNumber;

    public string GetNumber()
    {
        return Number;
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
            num=num + temp.ToString();
            
        }
        return num;

    }

    public string GetClient()
    {
        return Client;
    }
    public void SetClient(string name)
    {
        Client = name;
    }
    public decimal GetBalance()
    {
        return Balance;
    }
    public void SetBalance(decimal balance)
    {
        Balance = balance;
    }
    public TypeAccount1 GetTypeAccount()
    {
        return type;
    }
    public void SetTypeAccountDebet(TypeAccount1 typeAccount)
    {

        type = TypeAccount1.DEBET;


    }
    public void SetTypeAccountCredit(TypeAccount1 typeAccount)
    {

        type = TypeAccount1.CREDIT;


    }
    public void SetTypeAccountMixed(TypeAccount1 typeAccount)
    {

        type = TypeAccount1.MIXED;


    }
    public void Print()
    {
        Console.WriteLine($"Клиентe: {Client} открыт счет №: {Number} Тип: {type} Баланс: {Balance} ");
    }

}
