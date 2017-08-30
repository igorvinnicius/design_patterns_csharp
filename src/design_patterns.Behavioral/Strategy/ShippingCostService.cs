using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.Strategy
{
    public class ShippingCostService
    {
		private readonly IShippingCostCalculationStrategy CalculationStrategy;

		public ShippingCostService(IShippingCostCalculationStrategy calculationStrategy)
		{
			CalculationStrategy = calculationStrategy;
		}

		public double CalculateShippingCost(Order order)
		{
			return CalculationStrategy.CalculateShippingCost(order);
		}

    }
}
