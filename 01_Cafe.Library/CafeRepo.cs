using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.Library
{
    public class CafeRepo
    {
        public List<Cafe> _ListOfMenuItems = new List<Cafe>() { };

        //Create New Menu Items
        public void AddMenuItems(Cafe meal)
        {
            _ListOfMenuItems.Add(meal);
        }

        //Read List of All Menu Items
        public List<Cafe> GetMenuItemsList()
        {
            return _ListOfMenuItems;
        }

        //Delete Menu Items
        public bool RemoveMenuItem(Cafe meal)
        {
            //Cafe menuItem = GetMenuItemsList(mealName);

            if (meal == null)
            {
                return false;
            }
            else
            {
                return _ListOfMenuItems.Remove(meal);
            }
        }

        //Helper Method
        public Cafe GetMenuItemByMealName(string mealName)
        {
            foreach (Cafe meal in _ListOfMenuItems)
            {
                if (meal.MealName == mealName)
                {
                    return meal;
                }
            }
            return null;
        }
    }
}
