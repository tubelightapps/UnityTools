using UnityEngine;

namespace Observer
{  
    public class Enemy : MonoBehaviour, IPlayerObserver
    {
        Player playerObservable;

        private void Start()
        {
            playerObservable = FindObjectOfType<Player>();
            playerObservable.Add(this);
        }

        public void Notify()
        {
            Debug.Log("I am enemy - I know player's health is "+playerObservable.GetHealth());
        }
    }
}