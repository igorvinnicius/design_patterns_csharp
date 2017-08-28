using design_patterns.Creational.Builder;
using design_patterns.Creational.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace design_patterns.Creational.Tests
{
    public class BuilderTests
    {

		[Fact]
		public void Should_Return_A_BMWZ4_Car()
		{
			//Arrange
			var builder = new BMWZ4Builder();
			var maker = new CarMaker();

			//Act
			var car = maker.Construct(builder);

			//Assert
			Assert.Equal("BMW Z4", car.Model);
		}

		[Fact]
		public void Should_Return_A_AudiA4_Car()
		{
			//Arrange
			var builder = new AudiA4Builder();
			var maker = new CarMaker();

			//Act
			var car = maker.Construct(builder);

			//Assert
			Assert.Equal("Audi A4", car.Model);
		}

	}
}
