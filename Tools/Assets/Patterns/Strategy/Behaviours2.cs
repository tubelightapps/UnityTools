using UnityEngine;

namespace Strategy
{
    public class FlyLow : IFly
    {
        public void DoFly()
        {
            Debug.Log("Fly Low");
        }
    }

    public class SpeakLow : ISpeak
    {
        public void DoSpeak()
        {
            Debug.Log("Speak Low");
        }
    }

    public class JumpLow : IJump
    {
        public void DoJump()
        {
            Debug.Log("Jump Low");
        }
    }
}