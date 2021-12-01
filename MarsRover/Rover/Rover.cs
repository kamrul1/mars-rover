using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover.Rover
{
    public class Rover
    {
        private readonly Position _position;
        private readonly IDirection _direction;

        public Rover(Position position, IDirection direction)
        {
            _position = position;
            _direction = direction;
        }


        public Rover Apply(ICommand command)
        {
            return ApplyCommand((dynamic) command);
        }

        private Rover ApplyCommand(TurnLeftCommand c) 
            => new Rover(_position, _direction.ToLeft());

        private Rover ApplyCommand(TurnRightCommand c) 
            => new Rover(_position, _direction.ToRight());

        private Rover ApplyCommand(MoveForwardCommand c) 
            => new Rover(_direction.MoveForward(_position), _direction);

        public string PrintState() => $"{_position.X}:{_position.Y}:{_direction.AsDirectionCommand()}";
    }
}