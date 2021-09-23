using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineApplication.Service
{
    public class OrderManagementService: IOrderManagementService
    {
        public bool generatePackingSlipForShipping()
        {
            //implementation for generating Packing Slip For Shipping

            return true;
        }

        public bool duplicatePackingSlipForRoyaltyDepartment()
        {
            //implementation need to be done

            return true;
        }

        public bool activateMembership()
        {
            //implementation need to be done

            return true;
        }

        public bool upgradeMembership()
        {
            //implementation need to be done

            return true;
        }

        public bool addFirstAidvideo()
        {
            throw new NotImplementedException();
        }

        public bool commissionPaymentToAgent()
        {
            throw new NotImplementedException();
        }
    }
}
