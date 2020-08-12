using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure.MansionRooms
{
    public class Bedroom : DeadBody
    {
        public string BlankWalls { get; set; } = "An ordinary wallpaper design";
        public string Bed { get; set; } = "An ordinary twin bed";
        public string BedroomDoor { get; set; } = "The door is slightly ajar. (Was someone in here?)";
        public string TaxodermyBird { get; set; } = "Looks like a stuffed crow..";
        public bool IsInBedroom { get; set; }
        public DeadBody MurderScene { get; set; }
        public void EnterBedroom()
        {
            Console.WriteLine("Do you want to enter the bedroom? yes or no");
            var userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "yes")
            {
                IsInBedroom = true;
            }
        }
        public void SearchBedroom()
        {
            Console.WriteLine(this.Bed);
            Console.WriteLine(this.TaxodermyBird);
            Console.WriteLine($"");
        }
        public void ExitBedroom()
        {
            Console.WriteLine("Do you want to exit the bedroom? yes or no");
            var userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "yes")
            {
                IsInBedroom = false;
            }
        }

    }
}
