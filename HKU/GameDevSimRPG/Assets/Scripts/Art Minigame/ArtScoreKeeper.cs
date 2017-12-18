using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtScoreKeeper : MonoBehaviour
{

    public ChildrenRandomColor childrenRandomColor;

    public float Score;
    public float ScoreToGive;
    public float Energy = 10;
    public float EnergyCounter = 0;
    public float blocksClicked = 0;
    public float blocksNeededForReset;
    public float Timer;
    public float TimerMax;

    public Text ScoreText;
    public Text EnergyText;
    public Text ScoreText2;
    public Text EnergyText2;
    public Text FinalScoreText;
    public Text TimerText;

    public Slider EnergyBar;

    public bool removeable;


    // Use this for initialization
    void Start()
    {
        removeable = true;
        ScoreToGive = 50;
        childrenRandomColor = GetComponentInChildren<ChildrenRandomColor>();
        blocksNeededForReset = 64;
        TimerMax = 45;
        Timer = TimerMax;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        //Update UI

        ScoreText.text = "" + Score;
        EnergyText.text = Energy + "/10";
        TimerText.text = "Time: " + Mathf.Round(Timer);

        EnergyBar.value = Energy / 10;


        if (EnergyCounter >= 30 && Energy < 10 && Energy > 0)
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
            TimerText.gameObject.SetActive(false);

            FinalScoreText.text = "Game over\n your final score is\n" + Score;
        }

        if (blocksClicked == blocksNeededForReset)
        {
            TimerMax *= 0.85f;
            Timer = TimerMax;
            ScoreToGive += 5;
            childrenRandomColor.RandomColor();
            blocksNeededForReset += 64;
        }
        if (Timer < -1)
        {
            StartCoroutine(RemoveEnergy());
        }

    }

    public IEnumerator RemoveEnergy()
    {
        if (removeable == true)
        {
            Energy--;
            removeable = false; ;
            yield return new WaitForSeconds(1);
            removeable = true;
        }
    }
}
