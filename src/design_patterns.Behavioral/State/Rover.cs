using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.State
{
    public class Rover
    {
		public Direction Direction { get; set; }

		public IRoverDirection RoverDirection { get; set; }


		public Rover()
		{
			Direction = Direction.North;
		}

		public void TurnLeft()
		{
			RoverDirection.TurnLeft(this);
		}

		public void TurnRight()
		{
			RoverDirection.TurnRight(this);
		}

	}
}
