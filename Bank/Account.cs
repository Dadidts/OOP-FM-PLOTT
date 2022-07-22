namespace Bank;

internal class Account : IAccount
{

    private static string? _AccountNumber;
    private TypeAccount _Type;
    private decimal _Balance { get => _Balance; set => _Balance = value; }

    private Account(decimal balance, TypeAccount type)
    {
        _AccountNumber = GeneratorAccount();
        _Type = type;
        _Balance = balance;
        
    }
    //Генератор счета
    private static string GeneratorAccount()
    {
        string num = "40817810";
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            int temp = random.Next(-1, 10);
            int SetNumber = (random.Next(-1, 10));
            temp = (SetNumber * temp) / 2;
            if (temp < 0)
            {
                temp = 0;
            }
            else if (temp > 9)
            {
                temp = 1;
            }
            num += temp.ToString();

        }
        return num;

    }

    //+
    private decimal ReplenishmentAccount(decimal sum)
    {
        _Balance = _Balance + sum;
        return _Balance;
    }

    //-
    private decimal WithdrawalTransfer(decimal sum)
    {

        _Balance = _Balance - sum;
        return _Balance;

    }

    //Методы перевода
    private bool TransferFromAccount(Account account, Account account1, decimal amount)
    {
        WithdrawalTransfer(amount);
        ReplenishmentAccount(amount);
        return true;
    }
    private bool TransferFrom(Account account, decimal amount)
    {
        if (_Balance - amount >= 0)
        {

            return true;
        }

        else
        {

            return false;
        };
    }
    
}
