using _6_Lesson;

Console.SetBufferSize(120, 30);

bool flag = true;

while (flag)
{
   
    
    Console.Clear();
    Console.WriteLine("Выберите решение задачи:");
    Console.WriteLine("1- Решение задачи ДЗ № 1:");
    Console.WriteLine("2- Решение задачи ДЗ № 2:");
    Console.WriteLine("0- выход из программы:");

    
    int numMenu = NumbersMenu.Numbers("Введите номер: ");
    //Конец меню

    
    switch (numMenu)
    {
        case 0:
            {

                Console.Clear();
                Console.WriteLine("Программа завершена.");
                break;

            }
        case 1:
            {

                Console.Clear();
                DZ homeWork = new DZ();
                homeWork.HomeWork1();
                break;

            }
        case 2:
            {

                Console.Clear();
                DZ homeWork = new DZ();
                homeWork.HomeWork2();
                break;

            }
        default:
            {
                Console.WriteLine("Вы ввели неверный номер задачи. Укажите верный порядковый номер задачи.");
                break;
            }
    }

    
    if (numMenu == 0)
    {
        return;
    }

}

Console.WriteLine("Для выхода из программы нажмите любую кнопку...");
Console.ReadLine();
