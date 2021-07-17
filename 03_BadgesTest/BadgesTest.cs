using _03_Badges.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_BadgesTest
{
    [TestClass]
    public class BadgesTest
    {

        public Badges _badges;
        public BadgesRepo _badgesRepo;
        

        [TestInitialize]
        public void Arrange()
        {
            _badges = new Badges();
            _badgesRepo = new BadgesRepo();
            _badgesRepo.AddBadgeToDictionary(_badges);
        }

        [TestMethod]
        public void AddBadgeToDictionaryTest()
        {

        }

        [TestMethod]
        public void CreateDictionaryOfIDAndDoorListTest()
        {

        }

        [TestMethod]
        public void GetDictionaryOfIDAndDoorListTest()
        {

        }

        [TestMethod]
        public void UpdateDoorsForBadgeTest()
        {

        }

        [TestMethod]
        public void DeleteAllDoorsFromBadgeTest()
        {

        }
    }
}
