using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour {

    public float designExp;
    public float artExp;
    public float soundExp;
    public float CodingExp;

    public float designExpNeeded = 250;
    public float artExpNeeded = 250;
    public float soundExpNeeded = 250;
    public float CodingExpNeeded = 250;

    public Slider designBar;
    public Slider artBar;
    public Slider soundBar;
    public Slider codingBar;
	
	// Update is called once per frame
	void Update () {
        designBar.value = designExp / designExpNeeded;
        artBar.value = artExp / artExpNeeded;
        soundBar.value = soundExp / soundExpNeeded;
        codingBar.value = CodingExp / CodingExpNeeded;

    }
}
