namespace Strategy
{
    public class PollyHigh : Polly
    {
        void Start()
        {
            LoadPolly(new SpeakHigh(), new FlyHigh(), new JumpHigh());
            Execute();
        }
    }
}