using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameM
{    public class GameManager : MonoBehaviour
    {
        public static GameManager instance { get;private set; }
        public event System.Action OnGameOver;

        private void Awake()
        {
            SingletonThisGameobject();

        }
        private void SingletonThisGameobject()
        {
           if (instance == null) 
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            } 
        }
        public void GameOver()
        {
            OnGameOver.Invoke();
        }
    }
}
