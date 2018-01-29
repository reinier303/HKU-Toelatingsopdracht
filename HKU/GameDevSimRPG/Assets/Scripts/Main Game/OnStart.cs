using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnStart : MonoBehaviour {

    public GameObject NamePanel;
    public Text NameText;
    public SaveStats Save;

    void Start()
    {
        if(PlayerPrefs.GetInt("NameSaved") == 1)
        {
            NamePanel.SetActive(false);
            NameText.text = PlayerPrefs.GetString("CompanyName");
        }
    }
}
