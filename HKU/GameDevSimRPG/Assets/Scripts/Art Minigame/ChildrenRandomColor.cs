using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
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
	    float random2 = Random.Range(0, 101);
        float randomHue = random/100;

	    float random1or2 = Random.Range(0, 2);

	    if (random1or2 == 0)
	    {
	        randomHue = random / 100;
	    }
	    if (random1or2 == 1)
	    {
	        randomHue = random2 / 100;
	    }

        print(random);
	    print(random2);
        foreach (Image image in Images)
	    {
	        random1or2 = Random.Range(0, 2);

	        if (random1or2 == 0)
	        {
	            randomHue = random / 100;
	        }
	        if (random1or2 == 1)
	        {
	            randomHue = random2 / 100;
	        }
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
        float random2 = Random.Range(0, 101);
        float randomHue = random / 100;

        float random1or2 = Random.Range(0, 2);

        if (random1or2 == 0)
        {
            randomHue = random / 100;
        }
        if (random1or2 == 1)
        {
            randomHue = random2 / 100;
        }

        
        foreach (Image image in Images)
        {
            random1or2 = Random.Range(0, 2);

            if (random1or2 == 0)
            {
                randomHue = random / 100;
            }
            if (random1or2 == 1)
            {
                randomHue = random2 / 100;
            }
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

