using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    public void StartClicked()
    {
        GameManager.instance.LoadlevelScene(1);
    }
    public void ExitClicked()
    {
        GameManager.instance.Exit();
    }
}