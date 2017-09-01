using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.State
{
	public class RoverNorth : IRoverDirection
	{
		public void TurnLeft(Rover rover)
		{
			rover.Direction = Direction.West;
		}

		public void TurnRight(Rover rover)
		{
			rover.Direction = Direction.East;
		}
	}
}
