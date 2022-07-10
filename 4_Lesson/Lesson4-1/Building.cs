namespace _4_Lesson;

internal class Building
{
    //------------------------------------------------------------------------------------------------------------------------------------------
    //ПОЛЯ
    private static int _NumberBulid;         //Номер дома                               /*генерируем методом
    private float _HeightBulid;              //Высота дома                              */*Задается пользователем и/или высчитывается программно
    private float _HeightFloor;              //Высота этажа                             */*Задается пользователем и/или высчитывается программно
    private int _Apart;                      //Кол-во квартир в доме                    */*Задается пользователем и/или высчитывается программно
    private int _Floor;                      //Кол-во этажей                            */*Задается пользователем и/или высчитывается программно
    private int _ApartFloor;                 //Кол-во квартир на этаже в 1м подъезде    */*Задается пользователем
    private int _Entrance;                   //Кол-во подъездов в здании                */*Задается пользователем
    private int _ApartFloorEntrance;         //Кол-во квартир на этаже во всем здании   */*Задается пользователем и/или высчитывается программно
    private bool _Landscaped;                //Дом благоустроен /да; нет/               */*Задается пользователем
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
    //------------------------------------------------------------------------------------------------------------------------------------------
    //КОНСТРУКТОРЫ
    internal Building()
    {

    }
    //------------------------------------------------------------------------------------------------------------------------------------------
    //МЕТОДЫ ВЫЧИСЛЕНИЯ
    //Высчитываем кол-во квартир на этаже во всем здании
    internal int АpartamentsPerFloorEntrance()
    {

        return ApartFloorEntrance;

    }
    //Высчитываем кол-во квартир в доме
    internal int ApartamentsBuilding()
    {

        return Apart;

    }
    //Высчитываем высоту дома
    internal float HomeHeight()
    {

        return HeightBulid;

    }
    //Высчитываем высоту одного этажа
    internal float FloorHeight()
    {

        return HeightFloor;

    }
    //Высчетываем кол-во этажей
    internal int Floors()
    {
        return Floor;
    }
    //Генерация номера первого здания
    internal int NumberHome()
    {
        var ran = new Random();
        _NumberBulid = ran.Next(0, 11);
        return _NumberBulid;
    }
    //------------------------------------------------------------------------------------------------------------------------------------------

}
