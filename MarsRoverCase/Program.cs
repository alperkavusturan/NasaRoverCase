using System;
using MarsRoverCase.Models;

namespace MarsRoverCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting all inputs from console
            #region inputs

            double[] rectangleAr = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToDouble(arTemp));
            char[] positionRover1 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToChar(arTemp));
            char[] movementArRover1 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToChar(arTemp));

            char[] positionRover2 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToChar(arTemp));
            char[] movementArRover2 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToChar(arTemp));

            #endregion

            //Implement our Rovers and set their first values
            #region implementation

            Rover rover1 = new Rover();
            Rover rover2 = new Rover();

            rover1.Weight = rectangleAr[0];
            rover1.Height = rectangleAr[1];
            rover1.CurrentPosition = new Position 
            { 
                Latitude = Convert.ToDouble(positionRover1[0].ToString()), 
                Longitude = Convert.ToDouble(positionRover1[1].ToString()), 
                Head = positionRover1[2] 
            };

            rover2.Weight = rectangleAr[0];
            rover2.Height = rectangleAr[1];
            rover2.CurrentPosition = new Position
            {
                Latitude = Convert.ToDouble(positionRover2[0].ToString()),
                Longitude = Convert.ToDouble(positionRover2[1].ToString()),
                Head = positionRover2[2]
            };

            #endregion

            //Follow orders step by step
            #region applying

            foreach (var movement in movementArRover1)
            {
                switch (movement)
                {
                    case 'M':
                        rover1.MoveForward(rover1.CurrentPosition);
                        break;
                    case 'L':
                        rover1.TurnLeft(rover1.CurrentPosition);
                        break;
                    case 'R':
                        rover1.TurnRight(rover1.CurrentPosition);
                        break;
                }
            }

            foreach (var movement in movementArRover2)
            {
                switch (movement)
                {
                    case 'M':
                        rover2.MoveForward(rover2.CurrentPosition);
                        break;
                    case 'L':
                        rover2.TurnLeft(rover2.CurrentPosition);
                        break;
                    case 'R':
                        rover2.TurnRight(rover2.CurrentPosition);
                        break;
                }
            }

            #endregion


            //Output results
            #region output

            Console.WriteLine(rover1.CurrentPosition.Latitude.ToString() + ' ' + rover1.CurrentPosition.Longitude.ToString() + ' ' + rover1.CurrentPosition.Head.ToString());
            Console.WriteLine(rover2.CurrentPosition.Latitude.ToString() + ' ' + rover2.CurrentPosition.Longitude.ToString() + ' ' + rover2.CurrentPosition.Head.ToString());

            Console.ReadLine();

            #endregion
        }
    }
}
