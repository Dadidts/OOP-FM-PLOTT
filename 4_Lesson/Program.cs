using _4_Lesson;

bool f = true;

while (f)
{
    //Меню выбора решения
    Console.Clear();
    Console.WriteLine("Выберите решение задачи:");
    Console.WriteLine("1- Решение задачи ДЗ № 1:");
    Console.WriteLine("2- Решение задачи ДЗ № 2:");
    Console.WriteLine("3- Решение задачи ДЗ № 3:");
    Console.WriteLine("0- выход из программы:");

    int numMenu = int.Parse(Console.ReadLine());
    //Конец меню

    //Выбор решения задания
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
                Menu menu = new Menu();
                menu.Menu1();
                break;

            }
        case 2:
            {

                Console.Clear();
                Menu menu = new Menu();
                menu.Menu2();
                break;

            }
        case 3:
            {

                Console.Clear();
                Menu menu = new Menu();
                menu.Menu3();
                break;

            }
        default:
            {
                Console.WriteLine("Вы ввели неверный номер задачи. Укажите верный порядковый номер задачи.");
                break;
            }
    }

    //Конец выбора заадния
    //Условия для выхода из программы
    if (numMenu == 0)
    {
        return;
    }

}

Console.WriteLine("Для выхода из программы нажмите любую кнопку...");
Console.ReadLine();




}