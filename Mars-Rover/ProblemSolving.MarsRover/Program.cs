using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Command;
using ProblemSolving.MarsRover.Helper;
using ProblemSolving.MarsRover.Models;
using ProblemSolving.MarsRover.Rover;

namespace ProblemSolving.MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Plateau Top Right Bounds (Example : 5 5):"); // Prompt
            string plateauLine = Console.ReadLine();

            Plateau plateau = InputHelper.ParsePlateauInput(plateauLine);

            while (true)
            {
                Console.WriteLine("Enter Rover Positons and direction (Example : 1 2 N):");
                string roverLine = Console.ReadLine();

                Console.WriteLine("Enter Rover Command (Example : LMLMLMLMM):");
                string commandLine = Console.ReadLine();

                Rover.Rover rover = InputHelper.ParsePositionInput(roverLine, plateau);
                List<Command.ICommand> commands = InputHelper.ParseCommandInput(commandLine);
                rover.ExecuteCommandList(commands);
                Console.WriteLine(rover.CurrentLocation());

                Console.WriteLine("Press Enter for Continue!");
                ConsoleKeyInfo line = Console.ReadKey();
                if (line.Key != ConsoleKey.Enter)
                    break;
            }
        }
    }
}