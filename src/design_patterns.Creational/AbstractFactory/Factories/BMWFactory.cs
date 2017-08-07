using System;
using System.Collections.Generic;
using System.Text;
using design_patterns.Creational.AbstractFactory.Autos;
using design_patterns.Creational.AbstractFactory.Autos.BMW;

namespace design_patterns.Creational.AbstractFactory.Factories
{
	public class BMWFactory : IAutoFactory
	{
		public IAutomobile CreateEconomyCar()
		{
			return new BMW328i();
		}

		public IAutomobile CreateLuxuryCar()
		{
			return new BMW740i();
		}

		public IAutomobile CreateSportsCar()
		{
			return new BMWM3();
		}
	}
}
