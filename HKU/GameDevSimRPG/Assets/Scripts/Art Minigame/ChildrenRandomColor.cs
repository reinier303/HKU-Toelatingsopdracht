﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildrenRandomColor : MonoBehaviour
{
    public Component[] Panels;

	// Use this for initialization
	void Start ()
	{     
        Component[] Images = gameObject.GetComponentsInChildren(typeof(Image));

	    float random = Random.Range(0, 101);
	    float randomHue = random / 100;

	    print(randomHue);
	    foreach(Image image in Images)
	    {
	        image.color = Random.ColorHSV(randomHue, randomHue, 0.25f, 1f, 0.20f, 1f, 0.8f, 0.8f);
	        image.CrossFadeAlpha(0f, 0f, false);
        }
        gameObject.GetComponent<Image>().color = new Color(255,255,255,255);
	    gameObject.GetComponent<Image>().CrossFadeAlpha(1f, 0f, false);
    }
	
	public void RandomColor()
    {
        Component[] Images = gameObject.GetComponentsInChildren(typeof(Image));
        Component[] FadeScripts = gameObject.GetComponentsInChildren(typeof(FadeScript));

        float random = Random.Range(0, 101);
        float randomHue = random / 100;

        print(randomHue);
        foreach (Image image in Images)
        {
            image.color = Random.ColorHSV(randomHue, randomHue, 0.25f, 1f, 0.20f, 1f, 0.8f, 0.8f);
            image.CrossFadeAlpha(0f, 0f, false);
        }
        foreach (FadeScript fadeScript in FadeScripts)
        {
            fadeScript.scoreGiven = false;
        }
        gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        gameObject.GetComponent<Image>().CrossFadeAlpha(1f, 0f, false);
    }
}

