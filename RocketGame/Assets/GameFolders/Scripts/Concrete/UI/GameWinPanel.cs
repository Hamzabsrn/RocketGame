using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameWinPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadlevelScene(1);
        }
    }

}
