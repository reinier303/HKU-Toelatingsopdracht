﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    public Text text;
    public Outline outline;

    public CodingScoreKeeper codingScoreKeeper;

    public float FadeTime;

    private void Start()
    {
        codingScoreKeeper = GameObject.Find("Canvas").GetComponent<CodingScoreKeeper>();
        StartCoroutine(Fade());
    }

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        outline.effectColor = Color.white;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }


    private IEnumerator Fade()
    {
        text.CrossFadeAlpha(0, FadeTime, false);
        yield return new WaitForSeconds(FadeTime);

        codingScoreKeeper.Energy--;

        Destroy(gameObject);
    }
    
}