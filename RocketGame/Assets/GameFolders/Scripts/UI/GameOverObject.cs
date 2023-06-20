using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;

        private void Awake()
        {
            if (_gameOverPanel.activeSelf) { _gameOverPanel.SetActive(false); }
        }
        private void OnEnable()
        {
            GameManager.instance.OnGameOver += HandleOnGameOver;
        }
        private void OnDisable()
        {
            GameManager.instance.OnGameOver -= HandleOnGameOver;
        }
        private void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }

}
