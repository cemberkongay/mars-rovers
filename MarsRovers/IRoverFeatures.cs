namespace MarsRovers
{
    public interface IRoverFeatures
    {
        public void StepForward();
        public string MoveOn(string command);
        public void SpinLeft();
        public void SpinRight();
    }
}