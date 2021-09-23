using NUnit.Framework;
using RulesEngineApplication.Service;

namespace RulesEngineApplication.Test
{
    public class RuleEngineTest
    {
       public RuleEngine _ruleEngine;

        public RuleEngineTest()
        {

        }
        [SetUp]
        public void SetUp()
        {
            OrderManagementService omService = new OrderManagementService();
            _ruleEngine = new RuleEngine(omService);
        }

        [Test]
        public void paymentForBook_Test()
        {
            
            var result =_ruleEngine.paymentForBook();
            Assert.IsTrue(result);
        }
        [Test]
        public void paymentForMembership_Test()
        {

        }
        [Test]
        public void paymentForPhysicalProduct_Test()
        {
        }
        [Test]
        public void paymentForPhysicalProductOrBook_Test()
        {
        }
        [Test]
        public void paymentForUpgradingMembership_Test()
        {
        }
        [Test]
        public void paymentForVideoLearning_Test()
        {
        }
    }
}