namespace _2_Lesson.CBankOfRussia;

public class Account1
{
    private ulong Number;
    private string Client;
    private decimal Balance;
    private TypeAccount type;

    public ulong GetNumber()
    {
        return Number;
    }
    public void SetNumber(ulong number)
    {
        Number = number;
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
    public TypeAccount GetTypeAccount ()
    {
        return type;
    }
    public void SetTypeAccountDebet(TypeAccount typeAccount)
    {

        type = TypeAccount.DEBET;

        
    }
    public void SetTypeAccountCredit(TypeAccount typeAccount)
    {

        type = TypeAccount.CREDIT;


    }
    public void SetTypeAccountMixed(TypeAccount typeAccount)
    {

        type = TypeAccount.MIXED;


    }
    public void Print()
    {
        Console.WriteLine($"Клиент: {Client} Имеет счет №: {Number} Тип: {type} Баланс: {Balance} ");
    }

}
