using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.Strategy
{
	public class ShippingCalculationStrategyTwo : IShippingCostCalculationStrategy
	{
		public double CalculateShippingCost(Order order)
		{
			return 30d;
		}
	}
}
