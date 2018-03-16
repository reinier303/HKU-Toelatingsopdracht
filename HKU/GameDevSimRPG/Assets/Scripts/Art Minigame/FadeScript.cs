using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public ArtScoreKeeper artScoreKeeper;
    public bool scoreGiven = false;

    public void StartFade()
    {
        GetComponent<Image>().CrossFadeAlpha(1f, 0.3f, false);
        
        if (!scoreGiven)
        {
            artScoreKeeper.Score += artScoreKeeper.ScoreToGive;
            artScoreKeeper.blocksClicked++;
        }
        scoreGiven = true;
    }
}

