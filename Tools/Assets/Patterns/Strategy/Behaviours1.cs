using UnityEngine;

namespace Strategy
{
    public class FlyHigh : IFly
    {
        public void DoFly()
        {
            Debug.Log("Fly High");
        }
    }

    public class SpeakHigh : ISpeak
    {
        public void DoSpeak()
        {
            Debug.Log("Speak High");
        }
    }

    public class JumpHigh : IJump
    {
        public void DoJump()
        {
            Debug.Log("Jump High");
        }
    }
}