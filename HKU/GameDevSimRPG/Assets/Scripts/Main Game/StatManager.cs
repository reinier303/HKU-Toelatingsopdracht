using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

    public Text MoneyText;
    public Text NameText;
    public Text LvlText;

    public float Money;
    public int Fans;
    public int Lvl;

    public string CompanyName;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoneyText.text = "Money: " + Money;
        NameText.text = CompanyName;
        LvlText.text = "Lvl: " + Lvl;
    }
}
