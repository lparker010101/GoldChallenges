using _01_Cafe.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console_Cafe
{
    class ProgramUI
    {
        private CafeRepo _cafeRepo = new CafeRepo();
        public void Run()
        {
            CafeMenu();
            SeedMenuList();
        }

        private void CafeMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Menu Items:\n" +
                    "2. Remove Menu Item:\n" +
                    "3. Get a List of Menu Items:\n" +
                    "4. Exit Application");

                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input

                switch (input)
                {
                    case "1":
                        // Create New Menu Item
                        CreateMenuItem();
                        break;
                    case "2":
                        // Remove Menu Item
                        RemoveMenuItem();
                        break;
                    case "3":
                        // Get a List of Menu Items
                        GetListOfMenuItems();
                        break;
                    case "4":
                        // Exit Application
                        Console.WriteLine("Goodbye.  Have a nice day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("You entered an invalid number.  Please enter 1, 2, 3, 4.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        private void CreateMenuItem()
        {

        }

        private void RemoveMenuItem()
        {

        }

        private void GetListOfMenuItems()
        {

        }

        //Seed Method
        private void SeedMenuList()
        {
            Cafe cafeMenu1 = new Cafe(1, "Cheeseburger", "Our cheeseburger is made from 80% grass fed ground beef.", new List<string>() {"Bread","Beef","Cheese", "Lettuce", "Tomato"}, 3.59m);
            Cafe cafeMenu5 = new Cafe(5, "Chicken Sandwich", "Our chicken sandwich is a boneless chicken breast.", new List<string>() { "Bread", "Chicken", "Lettuce" }, 4.29m);

            _cafeRepo.AddMenuItems(cafeMenu5);
        }
    }
}
