using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineApplication.Service
{
    public interface IOrderManagementService
    {
        bool generatePackingSlipForShipping();
        bool duplicatePackingSlipForRoyaltyDepartment();
        bool activateMembership();
        bool upgradeMembership();
        bool addFirstAidvideo();
        bool commissionPaymentToAgent();
    }
}
