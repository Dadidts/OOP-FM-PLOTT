﻿using _4_Lesson;
using System.Collections.Generic;

internal class Menu
{
    internal void Menu1()
    {

        //Вывод перед началом работы программы.
        Console.WriteLine("Решение задачи №1. ");
        Console.WriteLine("Реализовать класс для описания здания (уник.№ здания, высота, этажность, кол-во квартир, подьездов.");
        Console.WriteLine("Поля-закрытые, предусмотреть методы для доступа заполнения полей и получения значений полей (Get/Set) Добавить методы вычисления:");
        Console.WriteLine("высоты этажа, кол-ва квартир в подьезде, кол-во квартир на этаже и проч. Предусмотреть возможность, что бы уникальный номер ");
        Console.WriteLine("генерировался программно. Для этого предусмотреть статическое поле, которое хранит последний использованный номер здания, и ");
        Console.WriteLine("предусмотреть метод, который увеличивал бы значение этого поля. В базу здания заводятся чтением из файла.");
        Console.WriteLine("==================================================================================================================================");
        //Конец
        MenuMenu1();

    }
    internal void MenuMenu1()
    {

        const string date_file_path = @"C:\Users\Стас\Desktop\!LS_GB\OOP\4_Lesson\Lesson4-1\File\Date.txt";
        var date_file = new FileInfo(date_file_path);

        var line_count = 0;
        foreach (var line in date_file.EnumLines())
        {

            line_count++;
            if (line_count < 3) continue;
                        
            var home = Building.ParseFile(line);            

            ListHome.Homes.Add(home);
           
        }
        Console.WriteLine("Данные в базу внесены.");
        Console.WriteLine("Для продолжение нажмите любую кнопку...");

        Console.ReadLine();

        ListHome.PrintList();

        Console.ReadLine();

        


    }








}
