namespace Bank;

internal interface IBankClient:IClient
{
    private string _Account { get => _Account; }
    private decimal _Balance { get => _Balance; set => _Balance = value; }    

}
