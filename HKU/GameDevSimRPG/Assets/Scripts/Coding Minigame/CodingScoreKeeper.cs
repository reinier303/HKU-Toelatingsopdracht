using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodingScoreKeeper : MonoBehaviour {

    public float Score;
    public float Energy = 10;
    public float EnergyCounter = 0;
    public float scoreToGive = 100;

    public Text ScoreText;
    public Text EnergyText;
    public Text ScoreText2;
    public Text EnergyText2;
    public Text FinalScoreText;

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

        if (EnergyCounter >= 15 && Energy < 10 && Energy > 0)
        {
            EnergyCounter = 0;
            Energy += 1;
        }

        if (Energy <= 0)
        {
            FinalScoreText.gameObject.SetActive(true);
            ScoreText.gameObject.SetActive(false);
            EnergyText.gameObject.SetActive(false);
            EnergyBar.gameObject.SetActive(false);
            ScoreText2.gameObject.SetActive(false);
            EnergyText2.gameObject.SetActive(false);

            FinalScoreText.text = "Game over\n your final score is\n" + Score;
        }
    }
}
