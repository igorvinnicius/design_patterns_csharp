using design_patterns.Creational.Builder.Builders;
using design_patterns.Creational.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.Builder
{
    public class CarMaker
    {
		public Car Construct(CarBuilder builder)
		{
			builder.CreateNewCar();
			builder.BuildModel();
			builder.BuildMotor();
			builder.BuildYear();
			builder.BuildPrice();

			return builder.GetCar();
		}

    }
}
