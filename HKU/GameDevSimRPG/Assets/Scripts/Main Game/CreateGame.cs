using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGame : MonoBehaviour {

    public SkillManager SkM;
    public StatManager StM;

    public GameObject GameStatPanel;

    public Text RatingText;
    public Text MoneyText;
    public Text FansText;

    public float Rating;
    public float designLvl;
    public float artLvl;
    public float soundLvl;
    public float codingLvl;
    public float totalLvl;

    public void Create()
    {
        CalculateRating();
        CalculateFans();
        CalculateMoney();
        GameStatPanel.SetActive(true);
    }

    void CalculateRating()
    {
        designLvl = SkM.designLvl;
        artLvl = SkM.artLvl;
        soundLvl = SkM.soundLvl;
        totalLvl = SkM.codingLvl;

        float designScore;
        float artScore;
        float soundScore;
        float codingScore;

        totalLvl = designLvl + artLvl + soundLvl + codingLvl;

        designScore = ((Random.Range(0, 6) / 10f) + Random.Range(Random.Range(designLvl / (designLvl * 1.25f), designLvl / (designLvl * 0.65f)), Random.Range(1f,4.5f) * Random.Range(designLvl / 40, designLvl / (2f + designLvl * 1.4f))));
        artScore = ((Random.Range(0, 6) / 10f) + Random.Range(Random.Range(artLvl / (artLvl * 1.25f), artLvl / (artLvl * 0.65f)), Random.Range(1f, 4.5f) * Random.Range(artLvl / 40, artLvl / (2f + artLvl * 1.4f))));
        soundScore = ((Random.Range(0, 6) / 10f) + Random.Range(Random.Range(soundLvl / (soundLvl * 1.25f), soundLvl / (soundLvl * 0.65f)), Random.Range(1f, 4.5f) * Random.Range(soundLvl / 40, soundLvl / (2f + soundLvl * 1.4f))));
        codingScore = ((Random.Range(0, 6) / 10f) + Random.Range(Random.Range(codingLvl / (codingLvl * 1.25f), codingLvl / (codingLvl * 0.65f)), Random.Range(1f, 4.5f) * Random.Range(codingLvl / 40, codingLvl / (2f + codingLvl * 1.4f))));

        Rating = designScore + artScore + soundScore + codingScore + Random.Range(-2f + (totalLvl / 35), 1.5f + (totalLvl / 35));

        if(Rating < 1)
        {
            Rating = 1;
        }
        RatingText.text = "Rating: " + Mathf.Round(Rating * 10) / 10 + "/10";
    }

    void CalculateFans()
    {
        float Fans = StM.Fans;  

        float FansGained = ((Fans + 1)) / Random.Range(12f - Rating,50 - (Rating * 2f)) + 1;

        StM.Fans += Mathf.Round(FansGained);

        FansText.text = "Fans Gained: " + Mathf.Round(FansGained);
    }

    void CalculateMoney()
    {
        float MoneyGained = Rating * (Random.Range(StM.Fans * 2f, StM.Fans * 8));

        if(Rating == 1)
        {
            MoneyGained *= 0.2f;
        }
        else if (Rating < 2)
        {
            MoneyGained *= 0.3f;
        }
        else if (Rating < 3)
        {
            MoneyGained *= 0.4f;
        }
        else if (Rating < 4)
        {
            MoneyGained *= 0.5f;
        }
        else if (Rating < 5)
        {
            MoneyGained *= 0.6f;
        }
        else if (Rating < 6)
        {
            MoneyGained *= 0.7f;
        }
        else if (Rating < 7)
        {
            MoneyGained *= 0.85f;
        }
        else if (Rating < 8)
        {
            MoneyGained *= 0.95f;
        }

        StM.Money += Mathf.Round(MoneyGained);

        MoneyText.text = "Money Gained: " + Mathf.Round(MoneyGained);
    }
}
