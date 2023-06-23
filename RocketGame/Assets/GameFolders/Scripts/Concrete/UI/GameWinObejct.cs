using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameWinObejct : MonoBehaviour
    {
        [SerializeField] GameObject _gameWinPanel;

        private void Awake()
        {
            if (_gameWinPanel.activeSelf)
            {
                _gameWinPanel.SetActive(false); 
            }
        }
        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }
        private void HandleOnMissionSucced()
        {
            if (!_gameWinPanel.activeSelf)
            {
                _gameWinPanel.SetActive(true);
            }
        }
    }

}
