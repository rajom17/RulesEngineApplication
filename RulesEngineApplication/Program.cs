using RulesEngineApplication;
using RulesEngineApplication.Service;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order Management Rule Engine Start");
            OrderManagement om = new OrderManagement(new RuleEngine(new OrderManagementService()));
            om.callRulesEngineBasedOnPaymetType("Book");
            Console.WriteLine("Order Management Rule Engine End");
        }
    }
}
