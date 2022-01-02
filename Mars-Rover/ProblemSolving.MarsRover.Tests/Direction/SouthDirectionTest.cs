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
    public class SouthDirectionTest
    {
        [Fact]
        public void WhenDirectionTurnRight_ThenNewDirectionIsWest()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new SouthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnRight();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.W, rover.Direction.Direction);
        }

        [Fact]
        public void WhenDirectionTurnLeft_ThenNewDirectionIsEast()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new SouthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnLeft();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.E, rover.Direction.Direction);
        }

        [Fact]
        public void WhenDirectionMove_ThenCoordinateYDecrease()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new SouthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.Move();

            //Assert
            Assert.Equal(--coordinate.CoordinateY, rover.Coordinate.CoordinateY);
        }
    }
}
