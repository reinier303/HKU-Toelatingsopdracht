using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public float Score;
    public float Energy = 10;
    public float EnergyCounter = 0;

    public Text ScoreText;
    public Text EnergyText;

    public Slider EnergyBar;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Update UI
        ScoreText.text = "" + Score;
        EnergyText.text = Energy + "/10";

        EnergyBar.value = Energy / 10;

        if (EnergyCounter >= 30 && Energy < 10 && Energy > 0)
        {
            EnergyCounter = 0;
            Energy += 1;
        }
    }
}
