namespace Bank;

public class AccountClient:IBankClient, IEquatable<AccountClient?>
{

    /*Поля*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/    
    private readonly Client _ClientBank;
    private readonly Account? _Account;   
    public static List<AccountClient> banksClient = new List<AccountClient>();
    
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    /*Свойства*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/    
    public Client ClientBank => _ClientBank;
    public Account Account => _Account!;
    
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    /*Конструкторы*/
    public AccountClient(Client client, Account account)
    {

        _ClientBank = client;
        _Account = account;

        banksClient.Add(this);

    }

    /*МЕТОДЫ КЛАССА*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    public override string ToString()
    {
        return string.Format(_ClientBank.ToString() + _Account!.ToString());
       
    }   

    public static void PrintAll()
    {
        foreach(AccountClient client in banksClient)
        {
            Console.WriteLine(client.ToString());
        }
    }

    public override bool Equals(object? obj)
    {

        if(obj is AccountClient accountClient)
            return _ClientBank == accountClient._ClientBank && _Account == accountClient._Account;
        return false;

    }

    public bool Equals(AccountClient? other)
    {
        return _ClientBank == other.ClientBank && _Account == other._Account;
    }

    public override int GetHashCode()
    {
        var hash = 11;
        hash = hash * _ClientBank.GetHashCode();
        hash = hash * _Account.GetHashCode();
        return hash;
    }

    public static AccountClient SearchAcc(int i)
    {
        
        return banksClient[i];

    }

    public static AccountClient SearchAccId(int i)
    {

        return banksClient[i];

    }
}
