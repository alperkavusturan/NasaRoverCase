using MarsRoverCase.Models;

namespace MarsRoverCase.Utils
{
    public abstract class NasaRoverBase
    {
        //Base properties for all Rover vehicles
        public double Weight { get; set; }
        public double Height { get; set; }
        public Position CurrentPosition { get; set; }

        //Base functions for all Rover vehicles
        public abstract void TurnLeft(Position position);
        public abstract void TurnRight(Position position);
        public abstract void MoveForward(Position position);
    }
}
