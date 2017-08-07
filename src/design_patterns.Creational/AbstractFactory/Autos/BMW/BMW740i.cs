using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Creational.AbstractFactory.Autos.BMW
{
	public class BMW740i : ILuxuryCar
	{
		public string Name { get; private set; }

		public bool SwitchedOn { get; private set; }

		public void AddLuxuryPackage()
		{
			
		}

		public void SetName(string name)
		{
			Name = name;
		}

		public void TurnOff()
		{
			SwitchedOn = false;
		}

		public void TurnOn()
		{
			SwitchedOn = true;
		}
	}
}
