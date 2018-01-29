using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveStats : MonoBehaviour {

    public StatManager StM;
    public SkillManager SkM;

    public void StatSave()
    {
        //Lvls
        PlayerPrefs.SetInt("CompanyLvl", StM.Lvl);
        PlayerPrefs.SetFloat("DesignLvl", SkM.designLvl);
        PlayerPrefs.SetFloat("CodingLvl", SkM.codingLvl);
        PlayerPrefs.SetFloat("ArtLvl", SkM.artLvl);
        PlayerPrefs.SetFloat("SoundLvl", SkM.soundLvl);

        //Money and Fans
        PlayerPrefs.SetFloat("Money", StM.Money);
        PlayerPrefs.SetFloat("Fans", StM.Fans);

        //Exp
        PlayerPrefs.SetFloat("CompanyExp", StM.CompanyExp);
        PlayerPrefs.SetFloat("DesignExp", SkM.designExp);
        PlayerPrefs.SetFloat("CodingExp", SkM.codingExp);
        PlayerPrefs.SetFloat("ArtExp", SkM.artExp);
        PlayerPrefs.SetFloat("SoundExp", SkM.soundExp);      
    }
}
