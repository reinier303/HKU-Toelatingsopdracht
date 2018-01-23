using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOn : MonoBehaviour {

    public GameObject MenuPanel;

    public void OpenMenu()
    {
        if(!MenuPanel.activeSelf)
        {
            MenuPanel.SetActive(true);
        }
        else
        {
            MenuPanel.SetActive(false);
        }
    }
}
