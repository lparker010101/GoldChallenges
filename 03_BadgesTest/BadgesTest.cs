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
            _badgesRepo.AddBadgesAndDoorsToDictionary(_badges);
        }

        [TestMethod]
        // Test: Create a new badge.
        public void AddBadgesAndDoorsToDictionaryTest()
        {
            // Arrange --> Setting Up
            Badges badgeID = new Badges();
            badgeID.BadgeID = 12345;

            int expected = 12345;
            int actual = badgeID.BadgeID;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        // Test: Create a dictionary of badgeID and door names.
        public void CreateDictionaryOfIDAndDoorListTest()
        {

        }

        [TestMethod]
        // Test: Show a list with all badge numbers and door access.
        public void GetDictionaryOfIDAndDoorListTest()
        {

        }

        [TestMethod]
        // Test: Update doors on an existing badge.
        public void UpdateDoorsForBadgeTest()
        {

        }

        [TestMethod]
        // Test: Delete all doors from an existing badge.
        public void DeleteAllDoorsFromBadgeTest()
        {

        }
    }
}
