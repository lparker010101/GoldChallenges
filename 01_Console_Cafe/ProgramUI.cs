using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console_Cafe
{
    class ProgramUI
    {
        public void Run()
        {
            CafeMenu();
        }

        private void CafeMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //Display options to the user
                Console.WriteLine("Select a meal number.  Meal Number:\n" +
                    "1. Select 1 for meal number 1. \n" +
                    "2. Select 2 for meal number 2. \n" +
                    "3. Select 3 for meal number 3. \n" +
                    "4. Select 4 for meal number 4. \n" +
                    "5. Select 5 for meal number 5.\n" +
                    "6. Exit");
                int input = int.Parse(Console.ReadLine());

                //Determine if menu option was selected and act accordingly.

                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("You just ordered #1. Great choice!");
                            break;
                        case 2:
                            Console.WriteLine("You just ordered #2.  Enjoy!");
                            break;
                        case 3:
                            Console.WriteLine("You just ordered #3.  Bon appetite.");
                            break;
                        case 4:
                            Console.WriteLine("You just ordered #4.  Yum!");
                            break;
                        case 5:
                            Console.WriteLine("You just ordered #5.  Wonderful choice!");
                            break;
                        case 6:
                            //Exit
                            keepRunning = false;
                            Console.WriteLine("Thank you for enjoying a meal with us today.  Please come and see us again soon.");
                            break;
                        default:
                            Console.WriteLine("Please enter a valid meal number. Options: 1, 2, 3, 4, 5");
                            break;
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
