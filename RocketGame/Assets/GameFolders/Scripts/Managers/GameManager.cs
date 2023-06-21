using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameobject();

        }
        private void SingletonThisGameobject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }
        public void LoadlevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }
        public void Exit()
        {
            Debug.Log("Logged Out");
            Application.Quit();
        }
    }

