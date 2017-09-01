using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.State
{
    public interface IRoverDirection
    {
		void TurnLeft(Rover rover);
		void TurnRight(Rover rover);
	}
}
