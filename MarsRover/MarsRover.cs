using System;
using System.Linq;
using MarsRover.Commands;
using MarsRover.Rover;

namespace MarsRover
{
    public class CommandFactory
    {
        public static ICommand CreateFrom(char c)
        {
            return c switch
            {
                'M' => new MoveForwardCommand(),
                'R' => new TurnRightCommand(),
                'L' => new TurnLeftCommand(),
                _ => throw new NotSupportedException($"Command {c} is not supported")
            };
        }
    }

    public class MarsRover : IMarsRover
    {
        private Rover.Rover _rover;


        public MarsRover(string initialState)
        {
            _rover = RoverFactory.CreateFrom(initialState);
        }

        public string Execute(string stringCommands)
        {

            var commands = stringCommands.ToCharArray().Select(CommandFactory.CreateFrom).ToList();
            
            commands.ForEach(c => _rover=_rover.Apply(c));
            
            return _rover.PrintState();
        }
    }
}