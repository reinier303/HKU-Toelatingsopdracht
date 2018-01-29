using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStats : MonoBehaviour {

    public static void StatSave()
    {
        //Lvls
        PlayerPrefs.SetInt("CompanyLvl", );
        PlayerPrefs.SetInt("DesignLvl", );
        PlayerPrefs.SetInt("CodingLvl", );
        PlayerPrefs.SetInt("ArtLvl", );
        PlayerPrefs.SetInt("SoundLvl", );

        //Money and Fans
        PlayerPrefs.SetFloat("Money",);
        PlayerPrefs.SetFloat("Fans",);

        //Exp
        PlayerPrefs.SetFloat("CompanyExp", );
        PlayerPrefs.SetFloat();
        PlayerPrefs.SetFloat();
        PlayerPrefs.SetFloat();
        PlayerPrefs.SetFloat();
    }
}
