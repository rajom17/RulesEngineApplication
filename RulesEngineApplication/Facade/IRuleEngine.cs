using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineApplication
{
    public interface IRuleEngine
    {
        //Rules- can also add new rules to the interface 
        bool paymentForPhysicalProduct();
        bool paymentForBook();
        bool paymentForMembership();
        bool paymentForUpgradingMembership();
        bool paymentForVideoLearning();
        bool paymentForPhysicalProductOrBook();
    }
}
