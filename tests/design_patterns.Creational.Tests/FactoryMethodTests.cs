using design_patterns.Creational.FactoryMethod.Autos;
using design_patterns.Creational.FactoryMethod.Factories;
using Xunit;

namespace design_patterns.Creational.Tests
{
    public class FactoryMethodTests
    {
		[Fact]
		public void A_BMWFactory_Should_Return_A_BMW_Instance()
		{
			//Arrange
			AutoFactory autoFactory = new BMWFactory();

			//Act
			var expectedInstance = autoFactory.CreateAutoMobile();

			var expectedType = typeof(BMW).FullName;

			var instanceType = expectedInstance.GetType().FullName;

			//Assert
			Assert.Equal(expectedType, instanceType);
		}

		[Fact]
		public void An_AudiFactory_Should_Return_An_Audi_Instance()
		{
			//Arrange
			AutoFactory autoFactory = new AudiFactory();

			//Act
			var expectedInstance = autoFactory.CreateAutoMobile();

			var expectedType = typeof(Audi).FullName;

			var instanceType = expectedInstance.GetType().FullName;

			//Assert
			Assert.Equal(expectedType, instanceType);
		}

	}
}
