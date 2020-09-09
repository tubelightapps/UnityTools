namespace Strategy
{
    public class PollyLow : Polly
    {
        void Start()
        {
            LoadPolly(new SpeakLow(), new FlyLow(), new JumpLow());
            Execute();
        }
    }
}
