using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineApplication
{
    public class OrderManagement
    {
        private readonly IRuleEngine _ruleEngine;

        public OrderManagement(IRuleEngine ruleEngine)
        {
            _ruleEngine = ruleEngine;
        }

        public bool callRulesEngineBasedOnPaymetType(string paymentType)
        {
            var Result = false;
            if(paymentType== "Book")
            {
                Result= _ruleEngine.paymentForBook();
            }
            return Result;
        }
    }
}
