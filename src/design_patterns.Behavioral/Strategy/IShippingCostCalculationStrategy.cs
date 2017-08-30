using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.Strategy
{
    public interface IShippingCostCalculationStrategy
    {
		double CalculateShippingCost(Order order);
    }
}
