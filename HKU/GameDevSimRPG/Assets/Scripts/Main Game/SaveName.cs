using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour {

    public InputField NameField;
    public Text NameText;

    public void NameSave()
    {
        string name = NameField.text;
        NameText.text = name;
        PlayerPrefs.SetString("CompanyName", name);
    }
}
