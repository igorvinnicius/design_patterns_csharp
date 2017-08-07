using design_patterns.Creational.AbstractFactory.Autos;
using design_patterns.Creational.AbstractFactory.Autos.BMW;
using design_patterns.Creational.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace design_patterns.Creational.Tests
{
    public class AbstractFactoryTests
    {

		[Fact]
		public void A_Factory_Should_Return_A_SportsCar_Instance()
		{
			//Arrange
			IAutoFactory autoFactory = new BMWFactory();

			//Act
			var expectedInstance = autoFactory.CreateSportsCar();

			var expectedType = typeof(BMWM3).FullName;

			var instanceType = expectedInstance.GetType().FullName;

			//Assert
			Assert.Equal(expectedType, instanceType);
		}

		[Fact]
		public void A_Factory_Should_Return_A_LuxuryCar_Instance()
		{
			//Arrange
			IAutoFactory autoFactory = new BMWFactory();

			//Act
			var expectedInstance = autoFactory.CreateLuxuryCar();

			var expectedType = typeof(BMW740i).FullName;

			var instanceType = expectedInstance.GetType().FullName;

			//Assert
			Assert.Equal(expectedType, instanceType);
		}

		[Fact]
		public void A_Factory_Should_Return_A_EconomyCar_Instance()
		{
			//Arrange
			IAutoFactory autoFactory = new BMWFactory();

			//Act
			var expectedInstance = autoFactory.CreateEconomyCar();

			var expectedType = typeof(BMW328i).FullName;

			var instanceType = expectedInstance.GetType().FullName;

			//Assert
			Assert.Equal(expectedType, instanceType);
		}

	}
}
