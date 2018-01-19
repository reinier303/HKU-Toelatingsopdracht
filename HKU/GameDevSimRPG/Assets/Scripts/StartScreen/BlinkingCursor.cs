using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingCursor : MonoBehaviour {

    public Text BlinkField;
    public Text inputField;
    public int maxCharacters = 30;

    private float delay = 0;
    private float cursorDelay = 0.65f;
    private bool blink;
    private string _text = "";

    // Update is called once per frame
    void Update () {
        var text = _text;

        if(inputField.text.Length < maxCharacters)
        {
            text += "Click to Continue";

            if(blink)
            {
                text = "";
            }
        }

        BlinkField.text = text;

        delay += Time.deltaTime;
        if(delay > cursorDelay)
        {
            delay = 0;
            blink = !blink;
        }
	}
}
