using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour {

    public float designLvl;
    public float artLvl;
    public float soundLvl;
    public float codingLvl;

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
        designBar.value = designExp / designExpNeeded;
        artBar.value = artExp / artExpNeeded;
        soundBar.value = soundExp / soundExpNeeded;
        codingBar.value = codingExp / codingExpNeeded;

        designLvlText.text = "Lvl: " + designLvl;
        artLvlText.text = "Lvl: " + artLvl;
        soundLvlText.text = "Lvl: " + soundLvl;
        codingLvlText.text = "Lvl: " + codingLvl;

        if (designExp >= designExpNeeded)
        {
            designLvl++;
            designExpNeeded *= Mathf.Round(1.5f * designExpNeeded);
        }
        if (artExp >= artExpNeeded)
        {
            artLvl++;
            designExpNeeded *= Mathf.Round(1.5f * designExpNeeded);
        }
        if (soundExp >= soundExpNeeded)
        {
            soundLvl++;
            designExpNeeded *= Mathf.Round(1.5f * designExpNeeded);
        }
        if (codingExp >= codingExpNeeded)
        {
            codingLvl++;
            designExpNeeded *= Mathf.Round(1.5f * designExpNeeded);
        }
    }
}
