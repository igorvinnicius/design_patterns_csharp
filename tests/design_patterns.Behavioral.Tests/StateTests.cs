using design_patterns.Behavioral.State;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace design_patterns.Behavioral.Tests
{
    public class StateTests
    {

		[Fact]
		public void When_Rover_Is_Facing_North_And_Turn_Right_It_Should_Face_East()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.North;
			rover.RoverDirection = new RoverNorth();

			//Act
			rover.TurnRight();

			//Assert
			Assert.Equal(Direction.East, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_North_And_Turn_Left_It_Should_Face_West()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.North;
			rover.RoverDirection = new RoverNorth();

			//Act
			rover.TurnLeft();

			//Assert
			Assert.Equal(Direction.West, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_East_And_Turn_Left_It_Should_Face_North()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.East;
			rover.RoverDirection = new RoverEast();

			//Act
			rover.TurnLeft();

			//Assert
			Assert.Equal(Direction.North, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_East_And_Turn_Right_It_Should_Face_South()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.East;
			rover.RoverDirection = new RoverEast();

			//Act
			rover.TurnRight();

			//Assert
			Assert.Equal(Direction.South, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_South_And_Turn_Left_It_Should_Face_East()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.South;
			rover.RoverDirection = new RoverSouth();

			//Act
			rover.TurnLeft();

			//Assert
			Assert.Equal(Direction.East, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_South_And_Turn_Right_It_Should_Face_West()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.South;
			rover.RoverDirection = new RoverSouth();

			//Act
			rover.TurnRight();

			//Assert
			Assert.Equal(Direction.West, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_West_And_Turn_Left_It_Should_Face_South()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.West;
			rover.RoverDirection = new RoverWest();

			//Act
			rover.TurnLeft();

			//Assert
			Assert.Equal(Direction.South, rover.Direction);
		}

		[Fact]
		public void When_Rover_Is_Facing_West_And_Turn_Right_It_Should_Face_North()
		{
			//Arrange
			Rover rover = new Rover();
			rover.Direction = Direction.West;
			rover.RoverDirection = new RoverWest();

			//Act
			rover.TurnRight();

			//Assert
			Assert.Equal(Direction.North, rover.Direction);
		}
	}
}
