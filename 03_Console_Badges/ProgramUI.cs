using _02_Claims.Library;
using _03_Badges.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Console_Badges
{
    public class ProgramUI
    {
        public BadgesRepo _badgesRepo = new BadgesRepo();
        Dictionary<int, List<string>> _dictionaryOfIDAndDoors = new Dictionary<int, List<string>>();

        public void Run()
        {
            Badges();
        }

        private void Badges()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display our options to the user.
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create a Badge:\n" +
                    "2. Update Doors on an Existing Badge:\n" +
                    "3. See a List of All Badge Numbers and Door Access:\n" +
                    "4. Exit Application");

                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input
                switch (input)
                {
                    case "1":
                        // Add a Badge
                        CreateBadge();
                        break;
                    case "2":
                        // Update Doors on an Existing Badge
                        UpdateDoorsOnBadge();
                        break;
                    case "3":
                        // Display a List of All Badge Numbers and Door Access
                        DisplayAllBadgeNumbersAndDoorAccess();
                        break;
                    case "4":
                        // Exit Application
                        Console.WriteLine("Goodbye.");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("You entered an invalid response.  Please try again.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        private void CreateBadge()
        {
            Badges newBadge = new Badges();

            Console.WriteLine("What is the number on the badge?");
            string inputAsString = Console.ReadLine();
            newBadge.BadgeID = int.Parse(inputAsString);

            Console.WriteLine("List a door that it needs access to: ");
            string inputAsString2 = Console.ReadLine();
            newBadge.DoorNames.Add(inputAsString2);

            bool isAddingDoors = true;
            while(isAddingDoors)
            {
                Console.WriteLine("Any other doors(y/n?");
                string input2 = Console.ReadLine();
                if(input2 == "y")
                {
                    Console.WriteLine("List a door that it needs access to: ");
                    string inputAsString4 = Console.ReadLine();
                    newBadge.DoorNames.Add(inputAsString4);
                }
                else
                {
                    isAddingDoors = false;
                }
            }
            _badgesRepo.AddBadgeToDictionary(newBadge);

            Console.WriteLine("Please press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        private void UpdateDoorsOnBadge()
        {
            Badges badgeID2 = new Badges();

            Dictionary<int, List<string>> SeeBadgeNumbersAndDoorAccess = _badgesRepo.GetDictionaryOfIDAndDoorList();

            foreach (KeyValuePair<int, List<string>> BadgesAndDoorAccess in SeeBadgeNumbersAndDoorAccess)
            {
                Display(BadgesAndDoorAccess);
            }

            Console.WriteLine("What is the badge number to update?");
            string inputAsString = Console.ReadLine();
            badgeID2.BadgeID = int.Parse(inputAsString);

            Console.WriteLine($"{inputAsString} has access to doors.  What would you like to do?  1. Remove a door  2. Add a door.");
            string inputAsString2 = Console.ReadLine();

            if (inputAsString2 == "1")
            {
                badgeID2.DoorNames.Remove(inputAsString2);
                Console.WriteLine("Which door would you like to remove?");
                string inputAsString3 = Console.ReadLine();
                badgeID2.DoorNames.Remove(inputAsString3);
                Console.WriteLine($"Door: {inputAsString3} removed.");

            }
            else
            {
                badgeID2.DoorNames.Add(inputAsString2);
                Console.WriteLine("Which door would you like to add?");
                string inputAsString5 = Console.ReadLine();
                badgeID2.DoorNames.Add(inputAsString5);
                Console.WriteLine($"Door: {inputAsString5} added.");
            }
        }
        private void DisplayAllBadgeNumbersAndDoorAccess()
        {
            Console.Clear();
            Dictionary<int, List<string>> SeeBadgeNumbersAndDoorAccess = _badgesRepo.GetDictionaryOfIDAndDoorList();

            foreach (KeyValuePair<int, List<string>> BadgesAndDoorAccess in SeeBadgeNumbersAndDoorAccess)
            {
                Display(BadgesAndDoorAccess);
            }
        }
        private void Display(KeyValuePair<int, List<string>> BadgesAndDoorAccess)
        {
            Console.WriteLine($"BadgeID: {BadgesAndDoorAccess.Key}");

            foreach(string DoorName in BadgesAndDoorAccess.Value)
            {
                Console.WriteLine($"DoorName: {DoorName}");
            }
        }
    }
}