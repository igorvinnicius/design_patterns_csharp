using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.AbstractFactory.Autos
{
    public interface IAutomobile
    {
		string Name { get; }

		bool SwitchedOn { get; }

		void SetName(string name);

		void TurnOn();

		void TurnOff();

	}
}
