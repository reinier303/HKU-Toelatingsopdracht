using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
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
            artScoreKeeper.Score += 100;
            artScoreKeeper.blocksClicked++;
        }
        scoreGiven = true;
    }
}

