using _4_Lesson.Lesson41;
using _4_Lesson.Lesson42;
using System.Globalization;

internal class Menu
{


    internal void Menu1()
    {

        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №1. ");
        Console.WriteLine("Реализовать класс для описания здания (уник.№ здания, высота, этажность, кол-во квартир, подьездов.");
        Console.WriteLine("Поля-закрытые, предусмотреть методы для доступа заполнения полей и получения значений полей (Get/Set) Добавить методы вычисления:");
        Console.WriteLine("высоты этажа, кол-ва квартир в подьезде, кол-во квартир на этаже и проч. Предусмотреть возможность, что бы уникальный номер ");
        Console.WriteLine("генерировался программно. Для этого предусмотреть статическое поле, которое хранит последний использованный номер здания, и ");
        Console.WriteLine("предусмотреть метод, который увеличивал бы значение этого поля. В базу здания заводятся чтением из файла.");
        Console.WriteLine("==================================================================================================================================");        
        MenuMenu1();

    }
    internal void Menu2()
    {

        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №2. ");
        Console.WriteLine("Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания. Для этого изменить");           
        Console.WriteLine("модификатор доступа к конструкторам класса, в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса");
        Console.WriteLine("здания. В классе Creator все методы сделать статическими, конструктор класса сделать закрытым. Для хранения объектов класса здания в классе Creator");
        Console.WriteLine("использовать хеш-таблицу. Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы. Создать тестовый пример,");
        Console.WriteLine("работающий с созданными классами. * Подозреваю что как всегда, где то накосячил....(((*");
        Console.WriteLine("==================================================================================================================================");
        //Конец
        MenuMenu2();

    }
    internal void MenuMenu1()
    {

        const string date_file_path = @"C:\Users\Стас\Desktop\!LS_GB\OOP\4_Lesson\Lesson4-1\File\Date.txt";
        var date_file = new FileInfo(date_file_path);

        var line_count = 0;
        foreach (var line in date_file.EnumLines())
        {

            line_count++;
            if (line_count < 3) continue;
                        
            var home = Building41.ParseFile(line);            

            ListHome.Homes.Add(home);
           
        }
        Console.WriteLine("Данные в базу внесены.");
        Console.WriteLine("Для продолжение нажмите любую кнопку...");

        Console.ReadLine();
        //Вывод на печать всей базы данных домов
        ListHome.PrintList();

        Console.ReadLine();

    }
    internal void MenuMenu2()
    {
        var date_file = FunctionMenu();        
        var line_count = 0;
        foreach (var line in date_file.EnumLines42())
        {

            line_count++;
            if (line_count < 3) continue;

            var values = line.Split(',');
            var street = values[0];
            var numberBulid = int.Parse(values[1]);
            var heightBulid = double.Parse(values[2], CultureInfo.InvariantCulture);
            var heightFloor = double.Parse(values[3], CultureInfo.InvariantCulture);
            var apart = int.Parse(values[4], CultureInfo.InvariantCulture);
            var floor = int.Parse(values[5], CultureInfo.InvariantCulture);
            var apartFloor = int.Parse(values[6], CultureInfo.InvariantCulture);
            var entrance = int.Parse(values[7], CultureInfo.InvariantCulture);
            var apartFloorEntrance = int.Parse(values[8], CultureInfo.InvariantCulture);
            var landscaped = bool.Parse(values[9]);
            var description = values[10];
                        
            ListHome42.Homes.Add(Creator.CreatorBuilding(heightBulid, heightFloor, apart, floor, apartFloor, entrance, apartFloorEntrance, landscaped, street, description));

        }

        Console.ReadLine();

        ListHome42.PrintList();

        Console.ReadLine();

    }   
    internal FileInfo FunctionMenu()
    {

        const string date_file_path = @"C:\Users\Стас\Desktop\!LS_GB\OOP\4_Lesson\Lesson4-2\File\Date.txt";
        var date_file = new FileInfo(date_file_path);
        return date_file;

    }

    
}
