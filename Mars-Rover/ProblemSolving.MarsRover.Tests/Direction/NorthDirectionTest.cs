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
    public class NorthDirectionTest
    {
        [Fact]
        public void WhenDirectionTurnRight_ThenNewDirectionIsEast()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnRight();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.E, rover.Direction.Direction);
        }

        [Fact]
        public void WhenDirectionTurnLeft_ThenNewDirectionIsWest()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnLeft();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.W, rover.Direction.Direction);
        }

        [Fact]
        public void WhenDirectionMove_ThenCoordinateYIncrease()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.Move();

            //Assert
            Assert.Equal(++coordinate.CoordinateY, rover.Coordinate.CoordinateY);
        }
    }
}
