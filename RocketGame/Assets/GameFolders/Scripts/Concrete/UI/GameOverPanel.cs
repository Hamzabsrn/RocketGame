using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadlevelScene();
        }
        public void NoClicked() 
        {
            GameManager.Instance.LoadMenuScene();
        }

    }

}
