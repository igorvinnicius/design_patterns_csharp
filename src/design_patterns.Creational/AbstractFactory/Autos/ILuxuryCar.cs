using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.AbstractFactory.Autos
{
    public interface ILuxuryCar : IAutomobile
    {
		void AddLuxuryPackage();
    }
}
