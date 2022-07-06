using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Lesson.Lesson31
{
    public class DBase
    {
        public static List<Account> accounts = new List<Account>();

        //Добавление в коллекцию элемент
        public static void AddList(Account account)
        {
            accounts.Add(account);
        }
        //Печать коллекции
        public static void PrintAllList()
        {
            foreach(Account account in accounts)
            {
                Console.WriteLine($"Клиенту: {account.Client} \t открыт счет №: {account.Number} Тип: {account.type} Баланс: {account.Balance}.");
            }
        }
        //отдельная печать одного клиента
        public static void Print(Account account)
        {
            Console.WriteLine($"Клиенту: {account.Client} открыт счет №: {account.Number} Тип: {account.type} Баланс: {account.Balance} ");
        }


    }
}
