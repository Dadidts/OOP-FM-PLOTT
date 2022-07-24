using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lesson
{
    public static class NumbersMenu
    {
        public static int Numbers(string message)
        {
            do
            {
                Console.Write(message);
                string text = Console.ReadLine();
                int result;
                if (int.TryParse(text, out result))
                {
                    return result;
                }
            }
            while (true);
        }
    }
}
