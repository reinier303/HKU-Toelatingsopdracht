using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{

    public void StartFade()
    {

        GetComponent<Image>().CrossFadeAlpha(1f, 0.3f, false);
    }

    //public IEnumerator Fade()
    //{

    //}
}
