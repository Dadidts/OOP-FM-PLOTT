namespace _2_Lesson.CBankOfRussia3;

public class Account3
{
    private string Number;
    private string Client;
    private decimal Balance;
    private TypeAccount3 type;
    public static int SetNumber;

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
        Console.WriteLine($"Клиентe: {Client} открыт счет №: {Number} Тип: {type} Баланс: {Balance} ");
    }

}
