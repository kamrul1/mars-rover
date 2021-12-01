using MarsRover.Rover;

namespace MarsRover.Directions
{
    public interface IDirection
    {
        Position MoveForward(Position position);
        IDirection ToRight();
        IDirection ToLeft();
        string AsDirectionCommand();
    }
}