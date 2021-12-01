using MarsRover.Rover;

namespace MarsRover.Directions
{
    public class East : IDirection
    {
        public Position MoveForward(Position position) => new Position(position.X+1, position.Y);
        public IDirection ToRight() => new South();
        public IDirection ToLeft() => new North();
        public string AsDirectionCommand() => "E";
    }
}