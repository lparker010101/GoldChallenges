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
        private BadgesRepo _badgesRepo = new BadgesRepo();
        public List<Badges> _listOfBadges = new List<Badges>();
        Dictionary<int, List<string>> _dictionaryOfIDAndDoors = new Dictionary<int, List<string>>();

        public void Run()
        {
            Badges();
            SeedBadges();
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
                    "3. Delete All Doors from an Existing Badge:\n" +
                    "4. See a List of All Badge Numbers and Door Access:\n" +
                    "5. Exit Application");

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
                        // Delete All Doors from an Existing Badge
                        DeleteAllDoorsFromBadge();
                        break;
                    case "4":
                        // Display a List of All Badge Numbers and Door Access
                        SeeListOfAllBadgeNumbersAndDoorAccess();
                        break;
                    case "5":
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

            Console.WriteLine("List a door that it needs access to: ");

            Console.WriteLine();

    }

    private void UpdateDoorsOnBadge()
        {

        }

        private void DeleteAllDoorsFromBadge()
        {

        }

        private void SeeListOfAllBadgeNumbersAndDoorAccess()
        {

        }

        private void SeedBadges()
        {

        }
    }
}
