namespace _5_Lesson.Lesson51;

internal class Calc
{

    internal static int NOK(int a, int b)
    {
        int nok = a*b/NOD(a,b);
       
        return nok;
    }
    internal static int NOD(int a, int b)
    {
        int i = a%b;
        a = b;
        b = i;
        if (i > 0)

            return NOD(a, b);

        else
            i = a;

        return i;
    }
    

}
