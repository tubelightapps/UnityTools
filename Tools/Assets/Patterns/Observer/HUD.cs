using UnityEngine;

namespace Observer
{
    public class HUD : MonoBehaviour, IPlayerObserver
    {
        Player playerObservable;

        private void Start()
        {
            playerObservable = FindObjectOfType<Player>();
            playerObservable.Add(this);
        }

        public void Notify()
        {
            Debug.Log("I am HUD - I know player's health is " + playerObservable.GetHealth());
        }
    }
}