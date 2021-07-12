using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Library
{
    public class Cafe
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal MealPrice { get; set; }

        public Cafe() { }

        public Cafe(int mealNumber, string mealName, string mealDescription, List<string> ingredients, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            MealPrice = mealPrice;
        }
    }
}
