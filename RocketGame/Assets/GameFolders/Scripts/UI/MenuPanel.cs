using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadlevelScene(1);
        }
        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }

}
