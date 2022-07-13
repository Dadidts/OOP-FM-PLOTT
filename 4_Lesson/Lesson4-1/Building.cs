namespace _4_Lesson;

internal class Building
{
    //------------------------------------------------------------------------------------------------------------------------------------------
    //ПОЛЯ
    private int _NumberBulid;                //Номер дома                                   **/*генерируем методом
    private float _HeightBulid;              //Высота дома                                  */*Задается пользователем и/или высчитывается программно
    private float _HeightFloor;              //Высота этажа                                 */*Задается пользователем и/или высчитывается программно
    private int _Apart;                      //Кол-во квартир в доме                        */*Задается пользователем и/или высчитывается программно
    private int _Floor;                      //Кол-во этажей                                */*Задается пользователем и/или высчитывается программно
    private int _ApartFloor;                 //Кол-во квартир на этаже в одномм подъезде    */*Задается пользователем
    private int _Entrance;                   //Кол-во подъездов в здании                    */*Задается пользователем
    private int _ApartFloorEntrance;         //Кол-во квартир на этаже во всем здании       */*Задается пользователем и/или высчитывается программно
    private bool _Landscaped;                //Дом благоустроен /да; нет/                   */*Задается пользователем
    private string? _Street;                 //Улица                                        */*Задается пользователем
    private int _NumberGenBulid = 0;         //Статическая переменная для хранения последнего номера дома
    //------------------------------------------------------------------------------------------------------------------------------------------
    //СВОЙСТВА
    public float HeightBulid
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
    public float HeightFloor
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
            _NumberBulid = value;
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------
    //КОНСТРУКТОРЫ
    //пустой конструктор
    internal Building()
    {

        NumberBulid = NumberHomeAdd();

    }

    //Конструктор, когда все данные по зданию известны (кроме номера дома)
    internal Building(float heightBulid, float heightFloor, int apart, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {

        HeightBulid = heightBulid;
        HeightFloor = heightFloor;
        Apart= apart;
        Floor = floor;
        ApartFloor= apartFloor;
        Entrance = entrance;
        ApartFloorEntrance = apartFloorEntrance;
        Landscaped= landscaped;
        Street= street;
        NumberBulid = NumberHomeAdd();
        
    }

    //Конструктор, когда высота дома не известна, все остальные данные известны (кроме номера дома)
    internal Building(float heightFloor, int apart, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {

        HeightBulid = HomeHeight(heightFloor, floor);
        HeightFloor = heightFloor;
        Apart = apart;
        Floor = floor;
        ApartFloor = apartFloor;
        Entrance = entrance;
        ApartFloorEntrance = apartFloorEntrance;
        Landscaped = landscaped;
        Street = street;
        NumberBulid = NumberHomeAdd();

    }

    //Конструктор, когда высота этажа не известна, все остальные данные известны (кроме номера дома)
    internal Building(int apart, float heightBulid, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {

        HeightBulid = heightBulid;
        HeightFloor = FloorHeight(heightBulid, floor);
        Apart = apart;
        Floor = floor;
        ApartFloor = apartFloor;
        Entrance = entrance;
        ApartFloorEntrance = apartFloorEntrance;
        Landscaped = landscaped;
        Street = street;
        NumberBulid = NumberHomeAdd();

    }

    //Конструктор, когда кол-во квартир в доме не известно, все остальные данные известны (кроме номера дома)
    internal Building(float heightBulid, float heightFloor, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {

        HeightBulid = heightBulid;
        HeightFloor = heightFloor;
        Apart = ApartamentsBuilding(floor, entrance, apartFloor);
        Floor = floor;
        ApartFloor = apartFloor;
        Entrance = entrance;
        ApartFloorEntrance = apartFloorEntrance;
        Landscaped = landscaped;
        Street = street;
        NumberBulid = NumberHomeAdd();

    }

    //Конструктор, когда кол-во этажей в доме не известно, все остальные данные известны (кроме номера дома)
    internal Building(int apart, float heightBulid, float heightFloor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {

        HeightBulid = heightBulid;
        HeightFloor = heightFloor;
        Apart = apart;
        Floor = Floors(heightBulid, heightFloor);
        ApartFloor = apartFloor;
        Entrance = entrance;
        ApartFloorEntrance = apartFloorEntrance;
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
    internal float HomeHeight(float heightFloor, int floor)
    {

        HeightBulid = heightFloor * floor;
        return HeightBulid;

    }
    
    //Вычисляем высоту одного этажа
    internal float FloorHeight(float heightBulid, int floor)
    {

        HeightFloor = heightBulid/ floor;
        return HeightFloor;

    }
    
    //Вычисляем кол-во этажей
    internal int Floors(float heightBulid, float heightFloor)
    {
        Floor = (int)(heightBulid / heightFloor);
        return Floor;
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

    //------------------------------------------------------------------------------------------------------------------------------------------








}
