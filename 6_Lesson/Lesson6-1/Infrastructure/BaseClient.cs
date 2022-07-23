using Bank;

namespace _6_Lesson.Lesson61.Infrastructure;

internal class BaseClient
{

    public static Client ParseFile(string line)
    {

        var values = line.Split(' ');
        var firstName = values[0];
        var lastName = values[1];
        var patronymic = values[2];
       

        var client = InterfaceBank.NewClient(firstName, lastName, patronymic);

        return client;

    }

    public static AccountClient NewAccountClient(Client client)
    {

        var accountClient = InterfaceBank.NewAccountClient(client);

        return accountClient;

    }

}
