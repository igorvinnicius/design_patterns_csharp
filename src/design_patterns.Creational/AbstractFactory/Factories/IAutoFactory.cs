using design_patterns.Creational.AbstractFactory.Autos;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.AbstractFactory.Factories
{
    public interface IAutoFactory
    {
		IAutomobile CreateSportsCar();
		IAutomobile CreateLuxuryCar();
		IAutomobile CreateEconomyCar();

    }
}
