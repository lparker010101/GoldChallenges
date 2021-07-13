using _01_Cafe.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_CafeTest
{
    [TestClass]
    public class CafeTest
    {
        private Cafe _cafe;
        private CafeRepo _repo;
        private CafeRepo _CafeRepo;

        [TestInitialize]
        public void Arrange()
        {
            _CafeRepo = new CafeRepo();
            _cafe = new Cafe();
            _CafeRepo.AddMenuItems(_cafe);
        }

        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            Cafe cafeMenu = new Cafe();
            cafeMenu.MealName = "1. Double Cheeseburger with Fries";

            string expected = "1. Double Cheeseburger with Fries";
            string actual = cafeMenu.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToMenuList_ShouldNotGetNull()
        {
            //Arrange --> Setting up
            Cafe meal = new Cafe();
            meal.MealName = "Double Cheeseburger with Fries";
            CafeRepo repository = new CafeRepo();

            //Act --> Get/run the code needed to test
            repository.AddMenuItems(meal);
            Cafe menuItem = repository.GetMenuItemByMealName("Double Cheeseburger with Fries");

            //Assert --> Use the assert class to verify the expected outcome.
            Assert.IsNotNull(menuItem);
        }

        [TestMethod]
        public void ReadMenuList()
        {
            Cafe menu = new Cafe();
            _CafeRepo.GetMenuItemsList();
        }

        [TestMethod]
        public void removeMenuItem_ShouldReturnTrue()
        {
            CafeRepo cafeRepo = new CafeRepo();
            bool removeMenuItem = _CafeRepo.RemoveMenuItem(_cafe);
            Assert.IsTrue(removeMenuItem);
        }
    }
}
