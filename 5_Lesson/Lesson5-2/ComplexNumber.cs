namespace _5_Lesson.Lesson52;

public struct ComplexNumber
{

    //Описываем полей комплексного числа
    #region
    //Поля класса
    public double _RealX;
    public double _MnimY;


    //Конструктор комплексного числа    
    internal ComplexNumber(double x, double y)
    {

        _RealX = x;
        _MnimY = y;

    }

    #endregion

    //МЕТОДЫ (ОПЕРАТОРЫ) РАБОТЫ С КОМПЛЕКСНЫМИ ЧИСЛАМИ
    //Сложение 2х комплексных чисел
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {

        ComplexNumber res = new ComplexNumber(0, 0);

        res._RealX = a._RealX + b._RealX;
        res._MnimY = a._MnimY + b._MnimY;

        return res;

    }

    //Умножение 2х комплексных чисел
    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {

        ComplexNumber res = new ComplexNumber(0, 0);
        res._RealX = (a._RealX* b._RealX)-(a._MnimY*b._MnimY);
        res._MnimY = ((a._RealX * b._MnimY) + (b._RealX * a._MnimY));               

        return res;

    }

    //Вычитание 2х комплексных чисел
    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {

        ComplexNumber res = new ComplexNumber(0, 0);
        res._RealX = a._RealX - b._RealX;
        res._MnimY = a._MnimY - b._MnimY;

        return res;

    }

    //Проверка на равенство
    public static bool operator ==(ComplexNumber a, ComplexNumber b)
    {

        if (a._RealX == b._RealX && a._MnimY == b._MnimY)
            return true;
        else
            return false;

    }

    public static bool operator !=(ComplexNumber a, ComplexNumber b)
    {
        if (a != b)
            return true;
        else
            return false;

    }

    //Переопределенный метод ToString()
    public override string ToString()
    {
        return string.Format($"({_RealX}, {_MnimY})");
    }

    //Переопределение Equals (че написал сам не понял) но вроде работает
    public override bool Equals(object? obj)
    {

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        var ob = (ComplexNumber)obj;
        return ob.Equals(this);

    }

    public bool Equals(ComplexNumber a)
    {
        return Equals(a, this);
    }

}
