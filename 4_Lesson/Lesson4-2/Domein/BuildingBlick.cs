namespace _4_Lesson.Lesson42;
internal class BuildingBlick : Building
{    
    //КОНСТРУКТОР   
    internal BuildingBlick(double heightBulid, double heightFloor, int apart, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street)
    {

        if (heightBulid is 0)
        {
            HeightBulid = HomeHeight(heightFloor, floor);
        }
        else HeightBulid = heightBulid;

        if (heightBulid is 0)
        {
            HeightFloor = FloorHeight(heightBulid, floor);
        }
        else HeightFloor = heightFloor;

        if (apart is 0)
        {
            Apart = ApartamentsBuilding(floor, entrance, apartFloor);
        }
        else Apart = apart;

        if (floor is 0)
        {
            Floor = Floors(heightBulid, heightFloor);
        }
        else Floor = floor;

        if (apartFloor is 0)
        {
            ApartFloor = ApartFloors(apart, floor, entrance);
        }
        else ApartFloor = apartFloor;

        if (apartFloorEntrance is 0)
        {
            ApartFloorEntrance = ApartFloorEntrances(apart, entrance);
        }
        else ApartFloorEntrance = apartFloorEntrance;

        Entrance = entrance;

        Landscaped = landscaped;

        Street = street;

        NumberBulid = NumberHomeAdd();

        Description = "КИРПИЧНЫЙ";

    }
   
}