using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Command;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Helper;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Helper
{
    public class InputHelperTest
    {
        [Theory]
        [InlineData("5 5", 5)]
        public void WhenCallParsePlateauInput_ThenPrintCoordinateXCorrectly(string plateauLine, int coordinateX)
        {
            //Arrange
            Plateau plateau = InputHelper.ParsePlateauInput(plateauLine);

            //Act

            //Assert
            Assert.Equal(coordinateX, plateau.TopRightCoordinate.CoordinateX);
        }

        [Theory]
        [InlineData("5 5", 5)]
        public void WhenCallParsePlateauInput_ThenPrintCoordinateYCorrectly(string plateauLine, int coordinateY)
        {
            //Arrange
            Plateau plateau = InputHelper.ParsePlateauInput(plateauLine);

            //Act

            //Assert
            Assert.Equal(coordinateY, plateau.TopRightCoordinate.CoordinateY);
        }

        [Theory]
        [InlineData("1 2 N", MarsRover.Direction.Direction.N)]
        public void WhenCallParsePositionInput_ThenPrintDirectionCorrectly(string roverLine, MarsRover.Direction.Direction direction)
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            MarsRover.Rover.Rover rover = InputHelper.ParsePositionInput(roverLine, plateau);

            //Act

            //Assert
            Assert.Equal(direction, rover.Direction.Direction);
        }

        [Theory]
        [InlineData("M", typeof(MoveCommand))]
        public void WhenCallParseCommandInput_ThenPrintCommandTypeCorrectly(string commandLine, Type type)
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new EastDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);
            List<MarsRover.Command.ICommand> commands = InputHelper.ParseCommandInput(commandLine);

            //Act

            //Assert
            Assert.IsType(type, commands[0]);
        }
    }
}
