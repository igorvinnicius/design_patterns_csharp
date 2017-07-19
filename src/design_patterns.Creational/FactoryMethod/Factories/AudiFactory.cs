using System;
using System.Collections.Generic;
using System.Text;
using design_patterns.Creational.FactoryMethod.Autos;

namespace design_patterns.Creational.FactoryMethod.Factories
{
	public class AudiFactory : AutoFactory
	{
		public override IAuto CreateAutoMobile()
		{
			return new Audi();
		}
	}
}
