namespace _4_Lesson;

internal static class ListHome
{
    //
    internal static List<Building> Homes = new List<Building>();

    //

    internal static void PrintList()
    {
        foreach (Building building in Homes)
        {

            Building.Print(building);

        }
        Console.WriteLine($"Всего зданий в базе данных: {Homes.Count}");

    }




}