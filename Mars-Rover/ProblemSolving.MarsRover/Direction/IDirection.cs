using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Direction
{
    public interface IDirection
    {
        Direction Direction { get; set; }
        IDirection TurnRight();
        IDirection TurnLeft();
        void Move(Rover.Rover rover);
    }
}
