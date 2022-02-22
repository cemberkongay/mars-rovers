using MarsRovers;
using Xunit;

namespace MarsRoversTests
{
    public class RoverShould
    {
        //The AAA (Arrange-Act-Assert) Pattern
        //It suggests that you should divide your test method into three sections: arrange, act and assert.
        //
        //Arrange => setup the testing objects and prepare the prerequisites for your test.
        //Act => perform the actual work of the test.
        //Assert => verify the result.
       
        [Fact]
        public void SpinLeft()
        {
            //Arrange
            int[] size = new int[2] { 5, 5 };
            RoverFeatures roverFeatures = new("1 2 N", size);

            //Act
            roverFeatures.SpinLeft();

            //Assert
            Assert.Equal("W", roverFeatures.Direction);
        }

        [Fact]
        public void SpinRight()
        {
            //Arrange
            int[] size = new int[2] { 5, 5 };
            RoverFeatures roverFeatures = new("1 2 N", size);

            //Act
            roverFeatures.SpinRight();

            //Assert
            Assert.Equal("E", roverFeatures.Direction);
        }

        [Fact]
        public void Forward()
        {
            //Arrange
            int[] size = new int[2] { 5, 5 };
            RoverFeatures roverFeatures = new("1 2 N", size);

            //Act
            roverFeatures.StepForward();

            //Assert
            Assert.Equal(3, roverFeatures.Y);
        }

        [Fact]
        public void ArriveAt_1_3_N()
        {
            //Arrange
            int[] size = new int[2] { 5, 5 };
            RoverFeatures roverFeatures = new("1 2 N", size);

            //Act
            roverFeatures.MoveOn("LMLMLMLMM");

            //Assert
            Assert.Equal("1 3 N", roverFeatures.X + " " + roverFeatures.Y + " " + roverFeatures.Direction);
        }

        [Fact]
        public void ArriveAt_5_1_E()
        {
            //Arrange
            int[] size = new int[2] { 5, 5 };
            RoverFeatures roverFeatures = new("3 3 E", size);

            //Act
            var result = roverFeatures.MoveOn("MMRMMRMRRM");

            //Assert
            Assert.Equal("5 1 E", result);
        }
    }
}
