using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour {

    public void SaveExp(float ExpToGive, int Minigame)
    {
        switch (Minigame)
        {
            case 1:
                PlayerPrefs.SetFloat("DesignExp", PlayerPrefs.GetFloat("DesignExp") + ExpToGive);
                break;
            case 2:
                PlayerPrefs.SetFloat("CodingExp", PlayerPrefs.GetFloat("CodingExp") + ExpToGive);
                break;
            case 3:
                PlayerPrefs.SetFloat("ArtExp", PlayerPrefs.GetFloat("ArtExp") + ExpToGive);
                break;
            case 4:
                PlayerPrefs.SetFloat("SoundExp", PlayerPrefs.GetFloat("SoundExp") + ExpToGive);
                break;
        }
    }
}
