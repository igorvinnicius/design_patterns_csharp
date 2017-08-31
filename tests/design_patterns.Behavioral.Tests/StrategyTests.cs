using design_patterns.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace design_patterns.Behavioral.Tests
{
    public class StrategyTests
    {

		[Fact]
		public void Should_Return_15_When_ShippingCalculationStrategyOne()
		{
			// Arrange
			var strategy = new ShippingCalculationStrategyOne();
			var service = new ShippingCostService(strategy);
			var order = new Order();
			
			// Act
			var cost = service.CalculateShippingCost(order);

			// Assert
			Assert.Equal(15, cost);
		}

		[Fact]
		public void Should_Return_30_When_ShippingCalculationStrategyTwo()
		{
			// Arrange
			var strategy = new ShippingCalculationStrategyTwo();
			var service = new ShippingCostService(strategy);
			var order = new Order();
			
			// Act
			var cost = service.CalculateShippingCost(order);

			// Assert
			Assert.Equal(30, cost);
		}

	}
}
