using System.Globalization;

namespace _4_Lesson.Lesson42;

internal class Building : IBuilding

{

    //------------------------------------------------------------------------------------------------------------------------------------------
    //ПОЛЯ

    protected int _NumberBulid;                //Номер дома                                   ***/*генерируем методом
    protected double _HeightBulid;             //Высота дома                                  ***/*Задается пользователем и/или высчитывается программно
    protected double _HeightFloor;             //Высота этажа                                 ***/*Задается пользователем и/или высчитывается программно
    protected int _Apart;                      //Кол-во квартир в доме                        ***/*Задается пользователем и/или высчитывается программно
    protected int _Floor;                      //Кол-во этажей                                ***/*Задается пользователем и/или высчитывается программно
    protected int _ApartFloor;                 //Кол-во квартир на этаже в одномм подъезде    ***/*Задается пользователем и/или высчитывается программно
    protected int _Entrance;                   //Кол-во подъездов в здании                    ***/*Задается пользователем
    protected int _ApartFloorEntrance;         //Кол-во квартир на этаже во всем здании       ***/*Задается пользователем и/или высчитывается программно
    protected bool _Landscaped;                //Дом благоустроен /да; нет/                   ***/*Задается пользователем
    protected string? _Street;                 //Улица                                        ***/*Задается пользователем
    protected static int _NumberGenBulid = 0;  //Статическая переменная для хранения последнего номера дома
    protected string? _Description;

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
    public string Description
    {
        get
        {
            return _Description!;
        }
        set
        {
            _Description = value;
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------
    //Методы
    //Вычисляем кол-во квартир в доме
    internal int ApartamentsBuilding(int floor, int entrance, int apartFloor)
    {
        Apart = apartFloor * entrance * floor;
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

        HeightFloor = heightBulid / floor;
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
        NumberBulid = _NumberGenBulid;
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
        if (_NumberGenBulid == 0)
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
    //Метод печати
    public static void Print(Building building)
    {

        Console.WriteLine("======================================================================================");
        Console.WriteLine("ИНФОРМАЦИЯ ПО ЖИЛОМУ ЗДАНИЮ.");
        Console.WriteLine($"Находящемуся по адресу: улица {building.Street} дом № {building.NumberBulid}.");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine($"Дом благоустроен: {building.Landscaped} Тип дома: {building.Description}");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine($"1. Количество этажей: {building.Floor} Высота одного этажа: {building.HeightFloor}");
        Console.WriteLine($"2. Количество подъездов: {building.Entrance}");
        Console.WriteLine($"3. Количество квартир: Всего {building.Apart}. На одном этаже: в одном подъезде: {building.ApartFloor} во всем здании: {building.ApartFloorEntrance} ");

    }

}