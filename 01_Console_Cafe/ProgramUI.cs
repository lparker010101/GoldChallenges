using _01_Cafe.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console_Cafe
{
    public class ProgramUI
    {
        private CafeRepo _cafeRepo = new CafeRepo();
        private List<Cafe> _listOfMenuItems = new List<Cafe>();

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
                        RemoveMenuItemUI();
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
            Cafe newMenuItem = new Cafe();

            Console.WriteLine("Enter a meal number.");
            string inputAsString = Console.ReadLine();
            newMenuItem.MealNumber = int.Parse(inputAsString);

            Console.WriteLine("Enter a meal name.");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter information about the meal.");
            newMenuItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter the price of the meal.");
            string inputAsString3 = Console.ReadLine();
            newMenuItem.MealPrice = decimal.Parse(inputAsString3);

         // Ingredients - Rework with while loop
            Console.WriteLine("What are the ingredients for this meal?");
            string inputAsString4 = Console.ReadLine();
            newMenuItem.Ingredients.Add(inputAsString4);
            _cafeRepo.AddMenuItems(newMenuItem);
        }

        private void RemoveMenuItemUI()
        {
            Console.WriteLine("What menu item do you want to remove?  Please enter a meal name.");
            string input = Console.ReadLine();

            Cafe meal = _cafeRepo.GetMenuItemByMealName(input);

            _cafeRepo.RemoveMenuItem(meal);
        }

        private void GetListOfMenuItems()
        {
            Console.Clear();
            List<Cafe> getListOfMenuItems = _cafeRepo.GetMenuItemsList();

            foreach (Cafe menuItem in getListOfMenuItems)
            {
                Console.WriteLine($"Meal Number: {menuItem.MealNumber}\n" +
                    $"Meal Name: {menuItem.MealName}\n" +
                    $"Meal Description: {menuItem.MealDescription}\n" +
                    $"Ingredients: {menuItem.Ingredients}\n" +
                    $"Meal Price: {menuItem.MealPrice}");
            }
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
