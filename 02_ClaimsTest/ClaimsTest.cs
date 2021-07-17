using _02_Claims.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_ClaimsTest
{
    [TestClass]
    public class ClaimsTest
    {
        private Claims _claims;
        private ClaimsRepo _claimsRepo;

        [TestInitialize]
        public void Arrange()
        {
            _claims = new Claims();
            _claimsRepo = new ClaimsRepo();
            _claimsRepo.AddClaims(_claims);
        }

        [TestMethod]
        public void AddClaimsCountTest()
        {
            int initialCount = _claimsRepo._queueOfClaims.Count;
            // Arrange --> Setting up
            Claims addClaim = new Claims(14444, "House", "House on Fire", 6000.00m, new DateTime(01 / 03 / 2003), new DateTime(04 / 31 / 2003), false);

            // Act --> Get/run the code needed to test
            _claimsRepo.AddClaims(addClaim);
            int newCount = _claimsRepo._queueOfClaims.Count;

            // Assert --> Use the assert class to verify the expected outcome.
            Assert.AreNotEqual(initialCount, newCount);
        }
        
        [TestMethod]
        public void DeleteClaimCountTest()
        {
            // Create Object    //Count
            Claims removeClaim = new Claims(14444, "House", "House on Fire", 6000.00m, new DateTime (01/03/2003), new DateTime (04/31/2003),false);
            _claimsRepo.AddClaims(removeClaim);
            int initialCount = _claimsRepo._queueOfClaims.Count;

            _claimsRepo.DeleteClaimFromQueue();  // Dequeue a claim
            int newCount = _claimsRepo._queueOfClaims.Count; // Test Count

            // Compare
            Assert.AreNotEqual(initialCount, newCount);
        }
    }
}
