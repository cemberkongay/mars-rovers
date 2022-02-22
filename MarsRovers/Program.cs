using System;

namespace MarsRovers
{
    //Mission Object:
    //Rover: Position and Location => (x,y,Z) where Z in {N, E, W, S}
    //
    //Plateua: Grid of positions => (x,y,z) where {0, 0, N} => (x=0, y=0, Z=N)
    //Plateua Size: MaximumCoordinates => (maxX, maxY) (5,5)
    //
    //Message: [*****...***] => * in (L, R, M). (L=> SpinLeft, R=> SpinRight, M=>MoveForward)
    //
    // 
    // Input Variables:
    //          1. Size -> MaximumCoordinates => (5,5)
    //          2. Rover starting point (x,y) and direction (Z)
    //          3. Message Command
    //
    // Behaviors:
    //          1. SpinLeft -> message command = L
    //          2. SpinRight -> message command = R
    //          3. MoveForward -> message command = M

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test Input:");
            Console.WriteLine();
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Console.WriteLine();

            RoverFeatures firstRover = new("1 2 N", new int[] {5,5});
            var firstRoverResult = firstRover.MoveOn("LMLMLMLMM");
            RoverFeatures secondRover = new("3 3 E", new int[] { 5, 5 });
            var secondRoverResult = secondRover.MoveOn("MMRMMRMRRM");

            Console.WriteLine("Expected Output:");
            Console.WriteLine();
            Console.WriteLine(firstRoverResult.ToString());
            Console.WriteLine(secondRoverResult.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
