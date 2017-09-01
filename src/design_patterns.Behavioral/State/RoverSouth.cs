using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.State
{
	public class RoverSouth : IRoverDirection
	{
		public void TurnLeft(Rover rover)
		{
			rover.Direction = Direction.East;
			rover.RoverDirection = new RoverEast();
		}

		public void TurnRight(Rover rover)
		{
			rover.Direction = Direction.West;
			rover.RoverDirection = new RoverWest();
		}
	}
}
