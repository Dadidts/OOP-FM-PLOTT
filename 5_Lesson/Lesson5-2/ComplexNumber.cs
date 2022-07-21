namespace _5_Lesson.Lesson52;

public struct ComplexNumber
{

    //Описываем поля комплексного числа
    #region
    //Поля класса
    private double _X;               
    private double _Y; 
    private double _I;

    //Свойства полей
    public double X
    {
        get { return _X; }
        set { _X = value; }
    }

    public double Y
    {
        get { return _Y; }
        set { _Y = value; }
        
    }
    public double Im
    {
        get { return _I; }
        set { _I = value; }
    }
    
    //Конструктор комплексного числа    
    internal ComplexNumber(double x, double y, double i)
    {
        X = x;
        Y = y;
        Im = i;
    }
    #endregion

    //МЕТОДЫ (ОПЕРАТОРЫ) РАБОТЫ С КОМПЛЕКСНЫМИ ЧИСЛАМИ
    //Сложение 2х комплексных чисел

    //Умножение 2х комплексных чисел

    //Вычитание 2х комплексных чисел

    //Проверка на равенство

    //Деление 2х комплексных чисел


    //Переопределенный метод ToString()


}
