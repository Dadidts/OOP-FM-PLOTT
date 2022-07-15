
using System.Globalization;

namespace _4_Lesson.Lesson41;

internal class Building
{
    //------------------------------------------------------------------------------------------------------------------------------------------
    //ПОЛЯ

    private int _NumberBulid;                //Номер дома                                   ***/*генерируем методом
    private double _HeightBulid;             //Высота дома                                  ***/*Задается пользователем и/или высчитывается программно
    private double _HeightFloor;             //Высота этажа                                 ***/*Задается пользователем и/или высчитывается программно
    private int _Apart;                      //Кол-во квартир в доме                        ***/*Задается пользователем и/или высчитывается программно
    private int _Floor;                      //Кол-во этажей                                ***/*Задается пользователем и/или высчитывается программно
    private int _ApartFloor;                 //Кол-во квартир на этаже в одномм подъезде    ***/*Задается пользователем и/или высчитывается программно
    private int _Entrance;                   //Кол-во подъездов в здании                    ***/*Задается пользователем
    private int _ApartFloorEntrance;         //Кол-во квартир на этаже во всем здании       ***/*Задается пользователем и/или высчитывается программно
    private bool _Landscaped;                //Дом благоустроен /да; нет/                   ***/*Задается пользователем
    private string? _Street;                 //Улица                                        ***/*Задается пользователем
    private static int _NumberGenBulid = 0;  //Статическая переменная для хранения последнего номера дома
    //------------------------------------------------------------------------------------------------------------------------------------------
    //СВОЙСТВА

    public double HeightBulid
    {
        get
        {
            return _HeightBulid;
        }
        set
        {
            _HeightBulid = value;
        }
    }
    public double HeightFloor
    {
        get
        {
            return _HeightFloor;
        }
        set
        {
            _HeightFloor = value;
        }
    }
    public int Apart
    {
        get
        {
            return _Apart;
        }
        set
        {
            _Apart = value;
        }
    }
    public int Floor
    {
        get
        {
            return _Floor;
        }
        set
        {
            _Floor = value;
        }
    }
    public int ApartFloor
    {
        get
        {
            return _ApartFloor;
        }
        set
        {
            _ApartFloor = value;
        }
    }
    public int Entrance
    {
        get
        {
            return _Entrance;
        }
        set
        {
            _Entrance = value;
        }
    }
    public int ApartFloorEntrance
    {
        get
        {
            return _ApartFloorEntrance;
        }
        set
        {
            _ApartFloorEntrance = value;
        }
    }
    public bool Landscaped
    {
        get
        {
            return _Landscaped;
        }
        set
        {
            _Landscaped = value;
        }
    }
    public string Street
    {
        get
        {
            return _Street!;
        }
        set
        {
            _Street = value;
        }
    }
    public int NumberBulid
    {
        get
        {
            return _NumberBulid;
        }
        set
        {

            if (_NumberBulid == 0)
                _NumberBulid = value;
            
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------
    //КОНСТРУКТОР

    public Building(double heightBulid, double heightFloor, int apart, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {
        
        if (heightBulid is 0)
        {
            HeightBulid = HomeHeight(heightFloor, floor);
        }
        else HeightBulid = heightBulid;

        if (heightBulid is 0)
        {
            HeightFloor = FloorHeight(heightBulid, floor);
        }
        else HeightFloor = heightFloor;

        if (apart is 0)
        {
            Apart = ApartamentsBuilding(floor, entrance, apartFloor);
        }
        else Apart = apart;

        if (floor is 0)
        {
            Floor = Floors(heightBulid, heightFloor);
        }
        else Floor = floor;

        if(apartFloor is 0)
        {
            ApartFloor = ApartFloors(apart, floor, entrance);
        }
        else ApartFloor = apartFloor;        

        if(apartFloorEntrance is 0)
        {
            ApartFloorEntrance = ApartFloorEntrances(apart,entrance);
        }
        else ApartFloorEntrance = apartFloorEntrance;

        Entrance = entrance;

        Landscaped = landscaped;

        Street = street;

        NumberBulid = NumberHomeAdd();
    }    
    //------------------------------------------------------------------------------------------------------------------------------------------
    //МЕТОДЫ ВЫЧИСЛЕНИЯ

    //Вычисляем кол-во квартир на этаже во всем здании
    internal int АpartamentsPerFloorEntrance()
    {

        return ApartFloorEntrance;

    }

    //Вычисляем кол-во квартир в доме
    internal int ApartamentsBuilding(int floor, int entrance, int apartFloor)
    {
        Apart = apartFloor* entrance* floor;
        return Apart;

    }
   
    //Вычисляем высоту дома
    internal double HomeHeight(double heightFloor, int floor)
    {

        HeightBulid = heightFloor * floor;
        return HeightBulid;

    }
    
    //Вычисляем высоту одного этажа
    internal double FloorHeight(double heightBulid, int floor)
    {

        HeightFloor = heightBulid/ floor;
        return HeightFloor;

    }
    
    //Вычисляем кол-во этажей
    internal int Floors(double heightBulid, double heightFloor)
    {
        Floor = (int)(heightBulid / heightFloor);
        return Floor;
    }

    //Вычисляем кол-во квартир на этаже в одномм подъезде
    internal int ApartFloors(int apart, int floor, int entrance)
    {
        ApartFloor = (apart / floor / entrance);
        return ApartFloor;
    }

    //Вычисляем кол-во квартир на 1 этаже в о всем здании
    internal int ApartFloorEntrances(int apartFloor, int entrance)
    {
        ApartFloorEntrance = apartFloor * entrance;
        return ApartFloorEntrance;
    }

    //Генерация номера первого здания
    internal int NumberHome()
    {
    //Генерируем рандомный номер первого здания. Если 1 то нечетная, если 2 то четная сторона улицы. 
        var random = new Random();
        _NumberGenBulid = random.Next(0, 3);
        NumberBulid= _NumberGenBulid;
        _NumberGenBulid += 2;
        return NumberBulid;
    }
    
    //Метод присваевания номера следующего дома
    internal int NumderHomeLast()
    {
        NumberBulid = _NumberGenBulid;
        _NumberGenBulid += 2;
        return NumberBulid;
    }
    //Добавляем к дому номер здания
    internal int NumberHomeAdd()
    {
        if(_NumberGenBulid == 0)
        {
            NumberBulid = NumberHome();
            return NumberBulid;
            
        }
        else
        {
            NumberBulid = NumderHomeLast();
            return NumberBulid;
        }

    }

    //Методы печачи:

    //Всего списка
    public static Building ParseFile(string line)
    {
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

        var home = new Building(heightBulid, heightFloor, apart, floor, apartFloor, entrance, apartFloorEntrance, landscaped, street);

        return home;
    }

    //Одного экземпляра
    public static void Print(Building building)
    {
        Console.WriteLine("======================================================================================");
        Console.WriteLine("ИНФОРМАЦИЯ ПО ЖИЛОМУ ЗДАНИЮ.");
        Console.WriteLine($"Находящемуся по адресу: улица {building.Street} дом № {building.NumberBulid}.");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine($"Дом благоустроен: {building.Landscaped}");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine($"1. Количество этажей: {building.Floor} Высота одного этажа: {building.HeightFloor}");
        Console.WriteLine($"2. Количество подъездов: {building.Entrance}");
        Console.WriteLine($"3. Количество квартир: Всего {building.Apart}. На одном этаже: в одном подъезде: {building.ApartFloor} во всем здании: {building.ApartFloorEntrance} ");
    }

} 







