using _03_Badges.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        // Test: Create a new badge.
        public void AddBadgesToDictionaryTest()
        {
            // Arrange --> Setting Up
            Badges badgeID = new Badges();
            badgeID.BadgeID = 12345;

            int expected = 12345;
            int actual = badgeID.BadgeID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // Test: Show a list with all badge numbers and door access.
        public void GetDictionaryOfIDAndDoorListTest()
        {
            Dictionary<int, List<string>> BadgesAndDoorAccess = _badgesRepo.GetDictionaryOfIDAndDoorList(); // Call a Method: Type, Name, = Value, ()
            Badges badges = new Badges();
            _badgesRepo.GetDictionaryOfIDAndDoorList();

            Assert.IsNotNull(BadgesAndDoorAccess);
        }
    }
}

