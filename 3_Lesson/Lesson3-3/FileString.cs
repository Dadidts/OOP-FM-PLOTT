using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_Lesson.Lesson33
{
    public class FileString
    {
        private static object line;

        public static void MyWorckFromFile(string path, string path1)
        {
              MyString(path, path1);        
            


        }
        //Обработка строки
        public static void SearchMail( ref string line)
        {
            //НАЧАЛО
            //Для поиска подстроки есть методы стандартные, тот же Сплит. но я попробую сделать это так как я вижу.
            //А именно: что есть строка?
            //строка это массив char. Так вот, берем строку, и работаем с ней, как с массивом, ищем наш разделитель & (про пробелы пока забываем)
            //После того как нашли наш разделитель, возвращаем его индекс в строке, проверяем, следующий символ не пробел? Т.к. он может идти сразу 
            //после разделителя, если да, записываем какой индекс. 
            //После чего, переводим массив символов снова в строку, и удаляем символы в строке от 0 до (1.вариант: разделителя включительно, 
            //2: если следом идет пробел, то удаляем от 0 до разделителя +1.
            //Возвращаем результат.
            //Как то так. может я конечно и не прав, но все же....
            //КОНЕЦ
            int temp=0;
            int temp2=0;
            for(int i = 0; i < line.Length-1; i++)
            {
                if(line[i]=='&')
                {
                    temp = i;

                    if (line[temp + 1] == ' ')
                    {
                        temp2 = i + 1;
                    }
                    else
                    {
                        temp2 = 0;
                    }

                }                
            }

              
            //Пользуемся ремуф. Сижу и думаю, а как работает ремуф? что бы пользоваться не им. а своим...
            //пробовал индекс переносить, что то не вышел у меня каменный цвяточек...
            if (temp2 != 0)
            {
                
                line = line.Remove(0, temp2+1);

            }
            else
            {
                line = line.Remove(0, temp+1);
            }

        }

        public static void MyString(string path, string path1)
        {
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(path1);

            //Читаем файл и по одной строке передает в цикл для обработки и записи в новый файл
            string line;
            while((line = sr.ReadLine()) != null)
            {
                SearchMail(ref line);
                sw.WriteLine(line);
                Console.WriteLine($"[{line}] - Строка записана в файл.") ;

            }
            
            
            //Закрываем Стримы
            sr.Close();
            sw.Close();
            Console.ReadLine();
        }
     

       


    }
}
