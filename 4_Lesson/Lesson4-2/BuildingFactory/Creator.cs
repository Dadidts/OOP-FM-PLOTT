namespace _4_Lesson.Lesson42;

internal abstract class Creator
{

    internal static Building CreatorBuilding(double heightBulid, double heightFloor, int apart, int floor, int apartFloor, int entrance, int apartFloorEntrance, bool landscaped, string street, string description)
    {
        if (description == " ")
        {

            var building = new BuildingOther(heightBulid, heightFloor, apart, floor, apartFloor, entrance, apartFloorEntrance, landscaped, street);
            return building;

        }

        else if (description == "Кирпичный")
        {

            var building = new BuildingBlick(heightBulid, heightFloor, apart, floor, apartFloor, entrance, apartFloorEntrance, landscaped, street);
            return building;

        }

        else if (description == "Панельный")
        {

            var building = new BuildingPanel(heightBulid, heightFloor, apart, floor, apartFloor, entrance, apartFloorEntrance, landscaped, street);
            return building;

        }
        else
        {

            var building = new BuildingOther(heightBulid, heightFloor, apart, floor, apartFloor, entrance, apartFloorEntrance, landscaped, street);
            return building;

        };

    }

}
