using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineApplication.Service
{
    public interface IOrderManagementService
    {
        bool generatePackingSlipForShipping();
    }
}
