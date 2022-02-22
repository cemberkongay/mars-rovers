using System;

namespace MarsRovers
{
    public class RoverFeatures : Position, IRoverFeatures
    {
        public RoverFeatures(string location, int[] size)
        {
            Int32.TryParse(location.Split(" ")[0], out X);
            Int32.TryParse(location.Split(" ")[1], out Y);
            Direction = location.Split(" ")[2];
            MaxX = size[0];
            MaxY = size[1];
        }
        public void SpinLeft()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "W";
                    break;
                case "E":
                    Direction = "N";
                    break;
                case "S":
                    Direction = "E";
                    break;
                case "W":
                    Direction = "S";
                    break;
                default:
                    break;
            }
        }

        public void SpinRight()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "N";
                    break;
                default:
                    break;
            }
        }

        public void StepForward()
        {
            switch (Direction)
            {
                case "N":
                    if (MaxY > Y)
                        Y += 1;
                    break;
                case "E":
                    if (MaxX > X)
                        X += 1;
                    break;
                case "S":
                    if (Y > 0)
                        Y -= 1;
                    break;
                case "W":
                    if (X > 0)
                        X -= 1;
                    break;
                default:
                    break;
            }
        }

        public string MoveOn(string command)
        {
            char[] instructions = command.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        break;
                }
            }
            return X + " " + Y + " " + Direction;
        }
    }
}
