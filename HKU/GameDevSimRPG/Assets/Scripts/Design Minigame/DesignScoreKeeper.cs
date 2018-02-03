using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesignScoreKeeper : MonoBehaviour {

    public ObstacleSpawner OS;

    public float Score;
    public float Energy = 10;
    public float EnergyCounter = 0;
    public float scoreToGive = 50;
    public float Timer;

    public Text ScoreText;
    public Text EnergyText;
    public Text ScoreText2;
    public Text EnergyText2;
    public Text FinalScoreText;

    public GameObject player;

    public Slider EnergyBar;

    // Update is called once per frame
    void Update()
    {
        //Update UI
        ScoreText.text = "" + Mathf.Round(Score);
        EnergyText.text = Energy + "/3";

        EnergyBar.value = Energy / 3;

        if (Energy <= 0)
        {
            FinalScoreText.gameObject.SetActive(true);
            ScoreText.gameObject.SetActive(false);
            EnergyText.gameObject.SetActive(false);
            EnergyBar.gameObject.SetActive(false);
            ScoreText2.gameObject.SetActive(false);
            EnergyText2.gameObject.SetActive(false);
            player.SetActive(false);
            OS.active = false;
            scoreToGive = 0;

            FinalScoreText.text = "Game over\n your final score is\n" + Mathf.Round(Score);
        }
        if(Energy > 0)
        {
            Timer -= Time.deltaTime;
            ExpSave(Score);
        }

        if(Timer <= 0)
        {
            Timer = 0.1f;
            scoreToGive += 0.075f;
            Score += scoreToGive / 10;
        }
    }

    public void ExpSave(float score)
    {
        float exp = score / 15;
        PlayerPrefs.SetFloat("DesignExp", exp);
    }
}
