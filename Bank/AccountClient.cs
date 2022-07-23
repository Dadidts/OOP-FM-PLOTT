namespace Bank;

public class AccountClient:IBankClient
{

    /*Поля*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/    
    private readonly Client _ClientBank;
    private readonly Account? _Account;   
    private static List<AccountClient> banksClient = new List<AccountClient>();
    
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    /*Свойства*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/    
    public Client ClientBank => _ClientBank;
    public Account Account => _Account!;
    
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    /*Конструкторы*/
    internal AccountClient(Client client, Account account)
    {

        _ClientBank = client;
        _Account = account;

        banksClient.Add(this);

    }

    internal AccountClient(Client client)
    {

        _ClientBank = client;
        _Account = null;

        banksClient.Add(this);

    }

    /*МЕТОДЫ КЛАССА*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/

}
