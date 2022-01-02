using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Models
{
    public class CoordinateTest
    {
        [Fact]
        public void WhenCall_ThenOverridedStringEqualToCoordinates()
        {
            //Arrange
            Coordinate coordinate = new Coordinate(1, 2);

            //Act

            //Assert
            Assert.Equal("1 2", coordinate.ToString());
        }
    }
}
