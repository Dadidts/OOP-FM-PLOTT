namespace _4_Lesson.Lesson42;

internal interface IBuilding
{
    internal int NumberBulid { get; set; }
    internal double HeightBulid { get; set; }
    internal double HeightFloor { get; set; }
    internal int Apart { get; set; }
    internal int Floor { get; set; }
    internal int ApartFloor { get; set; }
    internal int Entrance { get; set; }
    internal int ApartFloorEntrance { get; set; }
    internal bool Landscaped { get; set; }
    internal string? Street { get; set; }
    internal string? Description { get; set; }

    public static void Print(Building building)
    {

        Console.WriteLine("======================================================================================");
        Console.WriteLine("ИНФОРМАЦИЯ ПО ЖИЛОМУ ЗДАНИЮ.");
        Console.WriteLine($"Находящемуся по адресу: улица {building.Street} дом № {building.NumberBulid}.");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine($"Дом благоустроен: {building.Landscaped} Тип дома: {building.Description}");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine($"1. Количество этажей: {building.Floor} Высота одного этажа: {building.HeightFloor}");
        Console.WriteLine($"2. Количество подъездов: {building.Entrance}");
        Console.WriteLine($"3. Количество квартир: Всего {building.Apart}. На одном этаже: в одном подъезде: {building.ApartFloor} во всем здании: {building.ApartFloorEntrance} ");

    }


}
