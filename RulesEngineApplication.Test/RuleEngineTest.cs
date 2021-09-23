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
            // Time was less so created only positive senarios
            var result =_ruleEngine.paymentForBook();
            Assert.IsTrue(result);
        }
        [Test]
        public void paymentForMembership_Test()
        {
            var result = _ruleEngine.paymentForMembership();
            Assert.IsTrue(result);
        }
        [Test]
        public void paymentForPhysicalProduct_Test()
        {
            var result = _ruleEngine.paymentForPhysicalProduct();
            Assert.IsTrue(result);
        }
        [Test]
        public void paymentForPhysicalProductOrBook_Test()
        {
            var result = _ruleEngine.paymentForPhysicalProductOrBook();
            Assert.IsTrue(result);
        }
        [Test]
        public void paymentForUpgradingMembership_Test()
        {
            var result = _ruleEngine.paymentForUpgradingMembership();
            Assert.IsTrue(result);
        }
        [Test]
        public void paymentForVideoLearning_Test()
        {
            var result = _ruleEngine.paymentForVideoLearning();
            Assert.IsTrue(result);
        }
    }
}