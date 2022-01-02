using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Direction
{
    public class EastDirectionTest
    {
        [Fact]
        public void WhenDirectionTurnRight_ThenNewDirectionIsSouth()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new EastDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnRight();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.S, rover.Direction.Direction);
        }

        [Fact]
        public void WhenDirectionTurnLeft_ThenNewDirectionIsNorth()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new EastDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnLeft();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.N, rover.Direction.Direction);
        }

        [Fact]
        public void WhenDirectionMove_ThenCoordinateXIncrease()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new EastDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.Move();

            //Assert
            Assert.Equal(++coordinate.CoordinateX, rover.Coordinate.CoordinateX);
        }
    }
}
