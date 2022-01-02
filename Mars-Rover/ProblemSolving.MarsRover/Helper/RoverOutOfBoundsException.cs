using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Helper
{
    public class RoverOutOfBoundsException : Exception
    {
        public RoverOutOfBoundsException() : base(ExceptionMessages.RoverOutOfBounds)
        {

        }
    }
}
