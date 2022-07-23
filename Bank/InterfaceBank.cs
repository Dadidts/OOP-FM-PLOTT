namespace Bank;

public static class InterfaceBank
{

    public static Client NewClient(string firstName, string lastName, string patronymic)
    {

        var client = new Client(firstName, lastName, patronymic);

        return client;

    }

    public static AccountClient NewAccountClient(Client client)
    {
        var rnd = new Random();
        var num =  rnd.Next(0,4);
        TypeAccount type = (TypeAccount)num;
        var account = new Account(type);

        return new AccountClient(client, account);

    }

}
