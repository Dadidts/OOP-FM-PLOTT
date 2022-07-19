namespace _4_Lesson.Lesson41;

internal static class ListHome
{
    //
    internal static List<Building41> Homes = new List<Building41>();

    //

    internal static void PrintList()
    {
        foreach (Building41 building in Homes)
        {

            Building41.Print(building);

        }
        Console.WriteLine($"Всего зданий в базе данных: {Homes.Count}");

    }




}