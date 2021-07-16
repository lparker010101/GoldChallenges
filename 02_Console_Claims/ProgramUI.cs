using _02_Claims.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Console_Claims
{
    class ProgramUI
    {

        private ClaimsRepo _claimsRepo = new ClaimsRepo();
        private Queue<Claims> _queueOfClaims = new Queue<Claims>();


        public void Run()
        {
            InsuranceClaims();
            SeedClaims();
        }

        private void InsuranceClaims()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display our options to the user.
                Console.WriteLine("Select a menu option:\n +" +
                    "1. Add a claim" +
                    "2. See all claims" +
                    "3. Take care of next claim" +
                    "4. Exit Application");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input

                switch (input)
                {
                    case "1":
                        //Add a claim
                        AddClaims();
                        break;
                    case "2":
                        //See all claims
                        DisplayClaims();
                        break;
                    case "3":
                        //Take care of the next claim
                        NextClaim();
                        break;
                    case "4":
                        //Exit Application
                        Console.WriteLine("Goodbye.  Have a nice day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("You entered an invalid number.  Please try again.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        private void AddClaims()
        {
            Claims newClaim = new Claims();

            Console.WriteLine("Enter the claim ID number starting with number 1, then 2, and so on.");
            string inputAsString = Console.ReadLine();
            newClaim.ClaimID = int.Parse(inputAsString);

            Console.WriteLine("What is the claim type?  Example options: Car, Home, Theft");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter details about the claim.  Some examples: Car accident on 465, House fire in kitchen, Stolen pancakes");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the cost amount of the claim.  Enter the amount without using a $ sign.  Example: If it is $400, enter 400.");
            string inputAsString1 = Console.ReadLine();
            newClaim.ClaimAmount = int.Parse(inputAsString1);

            Console.WriteLine("Enter the date of the accident with 1 digit for the month, 2 digits for the day, and 2 digits for the year.  Example: 4/25/18");
            string inputAsString2 = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(inputAsString2);

            Console.WriteLine("Enter the date of the claim with 1 digit for the month, 2 digits for the day, and 2 digits for the year.  Example: 6/01/18");
            string inputAsString3 = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(inputAsString3);

            Console.WriteLine("Was the claim made within 30 days after an incident took place.  Enter yes or no.");
            string inputAsString4 = Console.ReadLine();
            newClaim.IsValid = Boolean.Parse(inputAsString4);
            _claimsRepo.AddClaims(newClaim);
        }

        private void DisplayClaims()
        {
            Console.Clear();
            Queue<Claims> seeClaims = _claimsRepo.DisplayAllClaims();

            foreach (Claims claims in seeClaims)
            {
                Display(claims);
            }
        }

        private void NextClaim()
        {
            Display(_claimsRepo.TakeCareOfNextClaim());
            Console.WriteLine("Do you want to deal with this claim now? (y/n)");
            string input = Console.ReadLine();

            if (input == "y")
            {
                _claimsRepo.DeleteClaimFromQueue();
            }
        }

        private void SeedClaims()
        {
            Claims claim1 = new Claims(1, "Car", "Car accident on 465", 400.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);
            Claims claim2 = new Claims(2, "Home", "House fire in kitchen", 4000.00m, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12), true);
            Claims claim3 = new Claims(3, "Theft", "Stolen pancakes", 4.00m, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01), false);

            _claimsRepo.AddClaims(claim1);
            _claimsRepo.AddClaims(claim2);
            _claimsRepo.AddClaims(claim3);
        }

        private void Display(Claims claims)
        {
            Console.WriteLine($"ClaimID: {claims.ClaimID}\n" +
                    $"Type: {claims.ClaimType}\n" +
                    $"Description: {claims.Description}\n" +
                    $"Amount: {claims.ClaimAmount}\n" +
                    $"DateOfAccident: {claims.DateOfIncident}\n" +
                    $"DateOfClaim: {claims.DateOfIncident}\n" +
                    $"IsValid: {claims.IsValid}");
        }
    }
}