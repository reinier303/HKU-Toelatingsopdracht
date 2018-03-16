using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour {

    public void SaveExp(float ExpToGive, int Minigame)
    {
        ExpToGive /= 5;
        switch (Minigame)
        {
            case 1:
                PlayerPrefs.SetFloat("DesignExp", PlayerPrefs.GetFloat("DesignExp") + Mathf.Round(ExpToGive));
                break;
            case 2:
                PlayerPrefs.SetFloat("CodingExp", PlayerPrefs.GetFloat("CodingExp") + Mathf.Round(ExpToGive));
                break;
            case 3:
                PlayerPrefs.SetFloat("ArtExp", PlayerPrefs.GetFloat("ArtExp") + Mathf.Round(ExpToGive));
                break;
            case 4:
                PlayerPrefs.SetFloat("SoundExp", PlayerPrefs.GetFloat("SoundExp") + Mathf.Round(ExpToGive));
                break;
        }
    }
}
