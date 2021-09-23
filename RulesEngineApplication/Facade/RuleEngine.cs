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
            result = _omService.duplicatePackingSlipForRoyaltyDepartment();
            return result;
        }

        public bool paymentForMembership()
        {
            var result = false;
            result = _omService.activateMembership();
            return result;
        }

        public bool paymentForPhysicalProduct()
        {
            var result = false;
            result = _omService.generatePackingSlipForShipping();
            return result;
        }

        public bool paymentForPhysicalProductOrBook()
        {
            var result = false;
            result = _omService.commissionPaymentToAgent();
            return result;
        }

        public bool paymentForUpgradingMembership()
        {
            var result = false;
            result = _omService.upgradeMembership();
            return result;
        }

        public bool paymentForVideoLearning()
        {
            var result = false;
            result = _omService.addFirstAidvideo();
            return result;
        }
    }
}
