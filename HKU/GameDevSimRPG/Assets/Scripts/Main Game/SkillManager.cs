using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour {

    public float designLvl = 1;
    public float artLvl = 1;
    public float soundLvl = 1;
    public float codingLvl = 1;

    public float designExp;
    public float artExp;
    public float soundExp;
    public float codingExp;

    public float designExpNeeded = 250;
    public float artExpNeeded = 250;
    public float soundExpNeeded = 250;
    public float codingExpNeeded = 250;

    public Slider designBar;
    public Slider artBar;
    public Slider soundBar;
    public Slider codingBar;

    public Text designLvlText;
    public Text artLvlText;
    public Text soundLvlText;
    public Text codingLvlText;

    // Update is called once per frame
    void Update () {
        designExp = PlayerPrefs.GetFloat("DesignExp");
        codingExp = PlayerPrefs.GetFloat("CodingExp");
        artExp = PlayerPrefs.GetFloat("ArtExp");
        soundExp = PlayerPrefs.GetFloat("SoundExp");

        designBar.value = designExp / designExpNeeded;
        artBar.value = artExp / artExpNeeded;
        soundBar.value = soundExp / soundExpNeeded;
        codingBar.value = codingExp / codingExpNeeded;

        designLvlText.text = "Lvl: " + designLvl;
        artLvlText.text = "Lvl: " + artLvl;
        soundLvlText.text = "Lvl: " + soundLvl;
        codingLvlText.text = "Lvl: " + codingLvl;

        if (designExp >= designExpNeeded && designLvl < 10)
        {
            designLvl++;
            designExpNeeded = Mathf.Round(1.8f * designExpNeeded);
        }
        if (artExp >= artExpNeeded && artLvl < 10)
        {
            artLvl++;
            artExpNeeded = Mathf.Round(1.8f * artExpNeeded);
        }
        if (soundExp >= soundExpNeeded && soundLvl < 10)
        {
            soundLvl++;
            soundExpNeeded = Mathf.Round(1.8f * soundExpNeeded);
        }
        if (codingExp >= codingExpNeeded && codingLvl < 10)
        {
            codingLvl++;
            codingExpNeeded = Mathf.Round(1.8f * codingExpNeeded);
        }
    }
}
