namespace Bank;

public class Client:IClient
{
    private readonly string _FirstName;
    private readonly string _LastName;
    private readonly string _Patronymic;
    private readonly int _Id;
    private static int SetId = 0;
    private static List<Client> clients = new List<Client>();

    public Client(string firstName, string lastName, string patronymic)    
    {
        _FirstName = firstName;
        _LastName = lastName;
        _Patronymic = patronymic;
        _Id = NewID();

        clients.Add(this);
        
    }

    private static int NewID()
    {
        int id = ++SetId;
        return id;
    }

    private static void PrintAll()
    {
        foreach(Client client in clients)
        {
            clients.ToString();
        }
    }

    //public override string ToString()
    //{
    //    return ToString($"ID: {_Id} Фамилия: {_FirstName} Имя: {_LastName} Отчество: {_Patronymic}");
    //}


}
