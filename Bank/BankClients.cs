namespace Bank;

internal class BankClients:IBankClient
{
    /*Поля*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    private readonly string _FirstName;
    private readonly string _LastName;
    private readonly string _Patronymic;
    private readonly string _Account;    
    private readonly int _Id;
    private decimal _Balance;
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/

    /*Свойства*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    public string FirstName => _FirstName;
    public string LastName => _LastName;
    public string Patronymic => _Patronymic;
    public string Account => _Account;
    public int Id => _Id;
    public decimal Balance { get => _Balance; set => _Balance = value; }
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/

    /*Конструктор*/


    /*МЕТОДЫ КЛАССА*/
    /*----------------------------------------------------------------------------------------------------------------------------------------------------*/





}
