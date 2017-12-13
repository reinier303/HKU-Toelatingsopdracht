using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

    public WordManager wordManager;
    public WordDisplay wordDisplay;
    public CodingScoreKeeper codingScoreKeeper;

    public float wordDelay = 3f;
    private float nextWordTime = 0.5f;

    private void Start()
    {
        wordDisplay.FadeTime = 10f;
    }

    private void Update()
    {
        if (codingScoreKeeper.Energy > 0)
        {
            if (Time.time >= nextWordTime)
            {
                wordManager.AddWord();
                nextWordTime = Time.time + wordDelay;
                wordDelay *= 0.995f;
                wordDisplay.FadeTime *= 0.997f;
            }
        }
    }
}
