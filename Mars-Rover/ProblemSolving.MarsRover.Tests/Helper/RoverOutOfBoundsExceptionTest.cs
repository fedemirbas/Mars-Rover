using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Helper;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Helper
{
    public class RoverOutOfBoundsExceptionTest
    {
        [Fact]
        public void WhenRoverIsCreatedWithANullPlateau_ThenThrowException()
        {
            //Arrange
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new EastDirection();
            
            //Act & Assert
            Assert.Throws<NullReferenceException>(() => new MarsRover.Rover.Rover(null, coordinate, direction));
        }

        [Fact]
        public void WhenRoverIsCreatedWithANullDirection_ThenThrowException()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);

            //Act

            //Assert
            Assert.Throws<NullReferenceException>(() => new MarsRover.Rover.Rover(plateau, coordinate, null));
        }

        [Fact]
        public void WhenRoverIsCreatedWithUnboundedCoordinate_ThenThrowException()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(11, 2);
            IDirection direction = new NorthDirection();

            //Act

            //Assert
            Assert.Throws<RoverOutOfBoundsException>(() => new MarsRover.Rover.Rover(plateau, coordinate, direction));
        }

        [Fact]
        public void WhenRoverIsMoveToNorthUnboundedCoordinate_ThenThrowException()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(plateau.TopRightCoordinate.CoordinateX, plateau.TopRightCoordinate.CoordinateY);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act

            //Assert
            Assert.Throws<RoverOutOfBoundsException>(() => rover.Move());
        }

        [Fact]
        public void WhenRoverIsMoveToEastUnboundedCoordinate_ThenThrowException()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(plateau.TopRightCoordinate.CoordinateX, plateau.TopRightCoordinate.CoordinateY);
            IDirection direction = new EastDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act

            //Assert
            Assert.Throws<RoverOutOfBoundsException>(() => rover.Move());
        }

        [Fact]
        public void WhenRoverIsMoveToSouthUnboundedCoordinate_ThenThrowException()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(plateau.BottomLeftCoordinate.CoordinateX, plateau.BottomLeftCoordinate.CoordinateY);
            IDirection direction = new SouthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act

            //Assert
            Assert.Throws<RoverOutOfBoundsException>(() => rover.Move());
        }

        [Fact]
        public void WhenRoverIsMoveToEstUnboundedCoordinate_ThenThrowException()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(plateau.BottomLeftCoordinate.CoordinateX, plateau.BottomLeftCoordinate.CoordinateY);
            IDirection direction = new WestDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act

            //Assert
            Assert.Throws<RoverOutOfBoundsException>(() => rover.Move());
        }
    }
}
