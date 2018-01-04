using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGame : MonoBehaviour {

    public SkillManager SM;

    public float Rating;
    public float designLvl;
    public float artLvl;
    public float soundLvl;
    public float codingLvl;
    public float totalLvl;

    public void Create()
    {
        CalculateRating();
    }

    void CalculateRating()
    {
        designLvl = SM.designLvl;
        artLvl = SM.artLvl;
        soundLvl = SM.soundLvl;
        totalLvl = SM.codingLvl;

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

        Debug.Log(Mathf.Round(Rating * 10) / 10);
    }
}
