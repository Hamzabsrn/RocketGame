using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.instance.LoadlevelScene();
        }
        public void NoClicked() 
        {
            GameManager.instance.LoadMenuScene();
        }

    }

}
