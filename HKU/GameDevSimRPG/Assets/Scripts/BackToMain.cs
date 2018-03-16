using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour {

    public Exp exp;
    public Text FinalScoreText;
    public float Finalscore;

    public void ToMain()
    {
        string Score = FinalScoreText.text.Replace("Game over\n your final score is\n", "");
        print(Score);
        Finalscore = Convert.ToInt32(Score);
        SceneManager.LoadScene(1);
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            exp.SaveExp(Mathf.Round(Finalscore), 3);
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            exp.SaveExp(Mathf.Round(Finalscore), 2);
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {

            exp.SaveExp(Mathf.Round(Finalscore), 1);
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            exp.SaveExp(Mathf.Round(Finalscore), 4);
        }
    }
}
