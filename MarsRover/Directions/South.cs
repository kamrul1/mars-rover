using MarsRover.Rover;

namespace MarsRover.Directions
{
    public class South : IDirection
    {
        public Position MoveForward(Position position) => new Position(position.X, position.Y-1);
        public IDirection ToRight() => new West();
        public IDirection ToLeft() => new East();
        public string AsDirectionCommand() => "S";
    }
}