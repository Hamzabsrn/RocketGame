using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinishFloor
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null) return;

            if (other.GetContact(0).normal.y == -1)
            {
                _finishFireWork.gameObject.SetActive(true);
                GameManager.instance.MissionSucced();
            }
            else
            {
                GameManager.instance.GameOver();
            }

        }
    }
}