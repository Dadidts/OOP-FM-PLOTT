using System.Diagnostics.CodeAnalysis;

namespace _5_Lesson.Lesson51;

internal struct RationalNumber
{
    #region
    //Поля класса
    private int _Num;               //Числитель
    private int _Den;               //Знаменатель

    //Свойства полей
    public int Num
    {
        get { return _Num; }
        set { _Num = value; }
    }

    public int Den
    {
        get { return _Den; }
        set
        {
            if (value > 0)
                _Den = value;
            else
                throw new ArgumentException("Знаметатель не может быть отрицательным");
        }
    }
    #endregion

    //Конструктор рационального числа
    internal RationalNumber(int num, int den)
    {
        _Num = num;
        _Den = den;

    }

    //Переопределенные методы (операторы) +,-,*,/,%,==,!=    
    //Сложение раиональных чисел
    public static RationalNumber operator +(RationalNumber a, RationalNumber b)
    {

        RationalNumber res = new RationalNumber(1, 1);

        if (a.Den == b.Den)
        {

            res.Num = a.Num + b.Num;
            res.Den = a.Den;

        }
        else
        {

            int NOK;
            NOK = Calc.NOK(a.Den, b.Den);

            res.Num = (a.Num * NOK / a.Den) + (b.Num * NOK / b.Den);
            res.Den = (a.Den * NOK / a.Den);

        }

        return res;

    }

    //Сложение рационального числа с целым числом
    public static RationalNumber operator +(RationalNumber a, int b)
    {

        RationalNumber res = new RationalNumber(a.Den, a.Den);
        
        res = a + res;        

        return res;

    }

    //Вычитание рациональных чисел
    public static RationalNumber operator -(RationalNumber a, RationalNumber b)
    {

        RationalNumber res = new RationalNumber(1, 1);

        if (a.Den == b.Den)
        {

            res.Num = a.Num - b.Num;
            res.Den = a.Den;

        }
        else
        {

            int NOK;
            NOK = Calc.NOK(a.Den, b.Den);

            res.Num = (a.Num * NOK / a.Den) - (b.Num * NOK / b.Den);
            res.Den = (a.Den * NOK / a.Den);


        }



        return res;

    }
    
    //Вычитание из целого числа рациональное число
    public static RationalNumber operator -(RationalNumber a, int b)
    {

        RationalNumber res = new RationalNumber(a.Den, a.Den);

        res.Num = res.Num - a.Num;

        return res;

    }

    //Вычитание из рационального числа целого числа
    public static RationalNumber operator -(int a, RationalNumber b)
    {

        RationalNumber res = new RationalNumber(a, a);
        
        res = res - b;
       
        return res;

    }

    //Умножение рациональных чисел
    public static RationalNumber operator *(RationalNumber a, RationalNumber b)
    {

        RationalNumber res = new RationalNumber(1, 1);

        res.Num = a.Num * b.Num;
        res.Den = a.Den * b.Den;

        return res;
    }

    //Умножение рационального числа на целое число
    public static RationalNumber operator *(RationalNumber a, int b)
    {
        RationalNumber res = new RationalNumber(1, 1);

        res.Num = a.Num * b;
        res.Den = a.Den;

        return res;

    }

    //Деление рaциональных чисел
    public static RationalNumber operator /(RationalNumber a, RationalNumber b)
    {
        RationalNumber res = new RationalNumber(b.Den, b.Num);

        res = a * res;

        return res;

    }

    //Деление рационального числа на целое число
    public static RationalNumber operator /(RationalNumber a, int b)
    {

        RationalNumber res = new RationalNumber(1, b);

        res = a * res;

        return res;
    }

    //Деление целого числа на рациональное число
    public static RationalNumber operator /(int a, RationalNumber b)
    {

        RationalNumber res = new RationalNumber(b.Den, b.Num);

        res.Num = a * b.Num;

        return res;
    }

    //% (Деление по модулю) рациональных чисел
    public static int operator %(RationalNumber a, RationalNumber b)
    {

        RationalNumber result = new RationalNumber(1, 1);
        int res = 0;

        result = a * b;

        if (result.Num > result.Den)
            return res = Calc.NOD(result.Num, result.Den);
        
        else
            return res;

    }

    //== рациональных чисел
    public static bool operator ==(RationalNumber a, RationalNumber b)
    {

        if (a.Num == b.Num && a.Den == b.Den)
            return true;
        else
            return false;

    }

    //!= рациональных чисел
    public static bool operator !=(RationalNumber a, RationalNumber b)
    {

        if (a.Num != b.Num)
            return true;
        else
            return false;
    }

    // Сравнение 2х рациональных чисел
    // a больше b
    public static bool operator >(RationalNumber a, RationalNumber b)
    {

        if (a > b)
            return true;
        else
            return false;
    }

    //< a меньше b
    public static bool operator <(RationalNumber a, RationalNumber b)
    {

        if (a < b)
            return true;
        else
            return false;
    }

    //<= a Больше или равно b
    public static bool operator <=(RationalNumber a, RationalNumber b)
    {

        if (a.Num <= b.Num && a.Den <= b.Den)
            return true;
        else
            return false;
    }

    //>= а Меньше или равно b
    public static bool operator >=(RationalNumber a, RationalNumber b)
    {

        if (a.Num >= b.Num && a.Den >=b.Den)
            return true;
        else
            return false;
    }

    //++ рациональное число
    public static RationalNumber operator ++(RationalNumber a)
    {
        const int i = 1;
        RationalNumber res = new RationalNumber(1, 1);

        res = a + i;

        return res;

    }

    //-- рациональное число
    public static RationalNumber operator --(RationalNumber a)
    {
        const int i = 1;
        RationalNumber res = new RationalNumber(1, 1);

        res = a - i;

        return res;

    }

    //Переопределенные методы
    //Переопределунный метот ToString()
    public override string ToString()
    {
        return string.Format($"{Num}/{Den}");
    }
    
    //Преобразуем обыкновенную дробь (вида a/b) в десятичную типа float
    public static float ToFloat(RationalNumber a)
    {

        float res = a.Num / a.Den;
        
        return res;

    }
    
    //Преобразование обыкновенной дроби (вида a/b) в целое число типа int
    public static int ToInt(RationalNumber a)
    {

        int res = a.Num / a.Den;

        return res;

    }

    //Переопределение Equals (че написал сам не понял) но вроде работает
    public override bool Equals(object? obj)
    {

        if(obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        var ob = (RationalNumber)obj;
        return ob.Equals(this);

    }

    public bool Equals(RationalNumber a)
    {
        return Equals(a, this);
    }

}
