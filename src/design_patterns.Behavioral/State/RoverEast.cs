using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.State
{
	public class RoverEast : IRoverDirection
	{
		public void TurnLeft(Rover rover)
		{
			rover.Direction = Direction.North;
			rover.RoverDirection = new RoverNorth();
		}

		public void TurnRight(Rover rover)
		{
			rover.Direction = Direction.South;
			rover.RoverDirection = new RoverSouth();
		}
	}
}
