using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

    public Text MoneyText;
    public Text LvlText;
    public Text FansText;

    public float Money;
    public float Fans;
    public int Lvl;
    public float CompanyExp;

    // Use this for initialization
    void Start ()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        MoneyText.text = "Money: " + PlayerPrefs.GetFloat("Money");
        FansText.text = "Fans: " + PlayerPrefs.GetFloat("Fans");
        LvlText.text = "Lvl: " + Lvl;
    }
}
