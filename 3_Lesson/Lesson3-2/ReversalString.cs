using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Lesson.Lesson32
{
    public class ReversalString
    {
        private static int i;
        private static int x;
        private static char ch;

        public static  void ReversalString1()
        {

            string s = "Ехал грека через реку";
            MyReverse(s);


        }
        //На входе получаем строку
        public static void MyReverse(string str)
        {

            char[] arrayChar;
            
            arrayChar = str.ToCharArray();

            //Переставляем местами символы. 1 с последним, второй с предпоследним, до тех пор пока i<x. Приводим к строке новый массив символов, выводим на консоль.
            for (i = 0, x = arrayChar.Length - 1; i < x; i++, x--)
            {

                ch = arrayChar[i];
                arrayChar[i] = arrayChar[x];
                arrayChar[x] = ch;
                

            }
            string str1 = new string(arrayChar);
            Console.WriteLine(str);
            Console.WriteLine(str1);

            Console.ReadLine();           


        }
     

    }
}
