using MarsRoverCase.Utils;

namespace MarsRoverCase.Models
{
    public class Rover : NasaRoverBase
    {

        //Overrode all functions for our specific Rover vechicle

        public override void MoveForward(Position position)
        {
            switch (position.Head)
            {
                case 'N':
                    position.Longitude++;
                    break;
                case 'E':
                    position.Latitude++;
                    break;
                case 'S':
                    position.Longitude--;
                    break;
                case 'W':
                    position.Latitude--;
                    break;
            }
        }

        public override void TurnLeft(Position position)
        {
            switch(position.Head)
            {
                case 'N':
                    position.Head = 'W';
                    break;
                case 'E':
                    position.Head = 'N';
                    break;
                case 'S':
                    position.Head = 'E';
                    break;
                case 'W':
                    position.Head = 'S';
                    break;
            }
        }

        public override void TurnRight(Position position)
        {
            switch (position.Head)
            {
                case 'N':
                    position.Head = 'E';
                    break;
                case 'E':
                    position.Head = 'S';
                    break;
                case 'S':
                    position.Head = 'W';
                    break;
                case 'W':
                    position.Head = 'N';
                    break;
            }
        }
    }
}
