using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public interface IPlayerObservable
    {
        void Add(IPlayerObserver playerObserver);
        void Remove(IPlayerObserver playerObserver);
        void Notify();
    }

    public interface IPlayerObserver
    {
        void Notify();
    }

    public class Player : MonoBehaviour, IPlayerObservable
    {        
        public int Health { get; private set; }

        List<IPlayerObserver> playerObserverList;
        
        public void OnAttack()
        {
            Health -= 10;
            Notify();
        }

        public void OnHeal()
        {
            Health += 5;
            Notify();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                OnAttack();

            if (Input.GetKeyDown(KeyCode.A))
                OnHeal();
        }
     
        public void Add(IPlayerObserver playerObserver)
        {
            if (playerObserverList == null)
                playerObserverList = new List<IPlayerObserver>();

            playerObserverList.Add(playerObserver);
        }

        public void Remove(IPlayerObserver playerObserver)
        {
            playerObserverList.Remove(playerObserver);
        }

        public void Notify()
        {
            foreach (var observer in playerObserverList)
            {
                observer.Notify();
            }
        }

        public int GetHealth()
        {
            return Health;
        }
    }
}