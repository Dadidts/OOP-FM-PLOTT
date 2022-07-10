namespace _4_Lesson;

internal class Building
{
    //Поля
    private static int _NumberBulid;         //номер дома  УДАЛИТЬ (будем придумывать хитрый генератор начального значения) КОНЕЦ УДАЛИТЬ 
    private float _HeightBulid;              //Высота дома
    private float _HeightFloor;              //Высота этажа
    private int _Apart;                      //Кол-во квартир в доме
    private int _Floor;                      //Кол-во этажей
    private int _ApartFloor;                 //Кол-во квартир на этаже в 1м подъезде
    private int _Entrance;                   //Кол-во подъездов в здании
    private int _ApartFloorEntrance;         //Кол-во квартир на этаже во всем доме
    private bool _Landscaped;                //Дом благоустроен /да; нет/

    


    //Свойства
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
    


    //Методы
    //Высчитываем высоту этажа

   








}
