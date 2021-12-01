namespace MarsRover.Rover
{
    public static class RoverFactory
    {
        public static Rover CreateFrom(string initialState)
        {
            var states = initialState.Split(":");
            var x = int.Parse(states[0]);
            var y = int.Parse(states[1]);
            var position = new Position(x, y);
            var directionStringCommand = states[2];
            var direction = Commands.CommandFactory.CreateFrom(directionStringCommand);
            return new Rover(position, direction);
        }
    }
}