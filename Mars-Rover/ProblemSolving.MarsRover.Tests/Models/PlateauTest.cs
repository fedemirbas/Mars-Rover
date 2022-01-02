using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Models
{
    public class PlateauTest
    {
        [Fact]
        public void WhenCall_ThenBottomLeftCoordinateXIsZero()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);

            //Act

            //Assert
            Assert.Equal(0, plateau.BottomLeftCoordinate.CoordinateX);
        }

        [Fact]
        public void WhenCall_ThenBottomLeftCoordinateYIsZero()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);

            //Act

            //Assert
            Assert.Equal(0, plateau.BottomLeftCoordinate.CoordinateY);
        }
    }
}
