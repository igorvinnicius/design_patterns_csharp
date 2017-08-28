using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.Builder.Builders
{
	public class AudiA4Builder : CarBuilder
	{
		public override void BuildModel()
		{
			Car.Model = "Audi A4";
		}

		public override void BuildMotor()
		{
			Car.Motor = "Audi A4 Motor";
		}

		public override void BuildPrice()
		{
			Car.Price = 350000;
		}

		public override void BuildYear()
		{
			Car.Year = 2017;
		}
	}
}
