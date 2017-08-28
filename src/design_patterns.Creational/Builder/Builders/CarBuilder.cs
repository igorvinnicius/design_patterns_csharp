using design_patterns.Creational.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.Builder.Builders
{
    public abstract class CarBuilder
    {
		protected Car Car { get; private set; }

		public void CreateNewCar()
		{
			Car = new Car();
		}

		public Car GetCar()
		{
			return Car;
		}

		public abstract void BuildModel();
		public abstract void BuildMotor();
		public abstract void BuildYear();
		public abstract void BuildPrice();

	}
}
