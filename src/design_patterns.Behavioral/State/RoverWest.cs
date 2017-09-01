﻿using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.State
{
	public class RoverWest : IRoverDirection
	{
		public void TurnLeft(Rover rover)
		{
			rover.Direction = Direction.South;
		}

		public void TurnRight(Rover rover)
		{
			rover.Direction = Direction.North;
		}
	}
}
