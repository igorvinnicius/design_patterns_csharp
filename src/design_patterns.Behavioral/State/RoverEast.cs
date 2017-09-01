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
		}

		public void TurnRight(Rover rover)
		{
			rover.Direction = Direction.South;
		}
	}
}
