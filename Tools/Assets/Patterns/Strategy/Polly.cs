using UnityEngine;

namespace Strategy
{

    public interface IJump
    {
        void DoJump();
    }

    public interface ISpeak
    {
        void DoSpeak();
    }

    public interface IFly
    {
        void DoFly();
    }

    public class Polly : MonoBehaviour
    {
        ISpeak iSpeak;
        IFly iFly;
        IJump iJump;

        public void LoadPolly(ISpeak iSpeak, IFly iFly, IJump iJump)
        {
            this.iSpeak = iSpeak;
            this.iFly = iFly;
            this.iJump = iJump;
        }

        public void Execute()
        {
            iSpeak.DoSpeak();
            iFly.DoFly();
            iJump.DoJump();
        }
    }
}