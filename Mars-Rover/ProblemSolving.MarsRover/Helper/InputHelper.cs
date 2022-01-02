using ProblemSolving.MarsRover.Command;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Helper
{
    public class InputHelper
    {
        public static Plateau ParsePlateauInput(String plateauLine)
        {
            String[] inputs = plateauLine.Split(' ');
            int topRightCoordinateX = Int32.Parse(inputs[0]);
            int topRightCoordinateY = Int32.Parse(inputs[1]);
            return new Plateau(topRightCoordinateX, topRightCoordinateY);
        }

        public static Rover.Rover ParsePositionInput(String positionLine, Plateau plateau)
        {
            String[] inputs = positionLine.Split(' ');
            int coordinateX = Int32.Parse(inputs[0]);
            int coordinateY = Int32.Parse(inputs[1]);

            Coordinate coordinate = new Coordinate(coordinateX, coordinateY);

            return new Rover.Rover(plateau, coordinate, GetDirection(inputs[2]));
        }

        private static IDirection GetDirection(string directionValue)
        {
            IDirection direction = null;
            Direction.Direction directionType = (Direction.Direction)Enum.Parse(typeof(Direction.Direction), directionValue);

            switch (directionType)
            {
                case Direction.Direction.E:
                    direction = new EastDirection();
                    break;
                case Direction.Direction.N:
                    direction = new NorthDirection();
                    break;
                case Direction.Direction.S:
                    direction = new SouthDirection();
                    break;
                case Direction.Direction.W:
                    direction = new WestDirection();
                    break;
                default:
                    break;
            }

            return direction;
        }

        public static List<ICommand> ParseCommandInput(String commandLine)
        {
            char[] inputs = commandLine.ToCharArray();
            List<ICommand> commandList = new List<ICommand>();

            foreach (char item in inputs)
            {
                commandList.Add(GetCommand(item));
            }

            return commandList;
        }

        private static ICommand GetCommand(char commandValue)
        {
            ICommand command = null;
            Command.Command commandType = (Command.Command)Enum.Parse(typeof(Command.Command), commandValue.ToString());

            switch (commandType)
            {
                case Command.Command.L:
                    command = new TurnLeftCommand();
                    break;
                case Command.Command.R:
                    command = new TurnRightCommand();
                    break;
                case Command.Command.M:
                    command = new MoveCommand();
                    break;
                default:
                    break;
            }

            return command;
        }
    }
}
