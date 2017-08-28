using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.Builder.Builders
{
	public class BMWZ4Builder : CarBuilder
	{
		public override void BuildModel()
		{
			Car.Model = "BMW Z4";
		}

		public override void BuildMotor()
		{
			Car.Motor = "Z4 Motor";
		}

		public override void BuildPrice()
		{
			Car.Year = 45000;
		}

		public override void BuildYear()
		{
			Car.Year = 2017;
		}
	}
}
