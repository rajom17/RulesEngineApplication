using RulesEngineApplication.Service;
using System;

namespace RulesEngineApplication
{
    public class RuleEngine : IRuleEngine
    {
        private readonly IOrderManagementService _omService;
        public RuleEngine(IOrderManagementService omService)
        {
            _omService = omService;
        }
        public bool paymentForBook()
        {
            var result = false;
            result = _omService.generatePackingSlipForShipping();
            return result;
        }

        public bool paymentForMembership()
        {
            throw new NotImplementedException();
        }

        public bool paymentForPhysicalProduct()
        {
            throw new NotImplementedException();
        }

        public bool paymentForPhysicalProductOrBook()
        {
            throw new NotImplementedException();
        }

        public bool paymentForUpgradingMembership()
        {
            throw new NotImplementedException();
        }

        public bool paymentForVideoLearning()
        {
            throw new NotImplementedException();
        }
    }
}
