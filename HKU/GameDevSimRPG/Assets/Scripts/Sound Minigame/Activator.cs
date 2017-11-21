using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour {

    public KeyCode key;

    bool active = false;

    GameObject note;

    public Image image;

    public Sprite baseSprite;
    public Sprite downSprite;

    public bool createMode;

    public GameObject parent;
    public GameObject n;
	
	// Update is called once per frame
	void Update ()
    {
        if(createMode == true)
        {
            if (Input.GetKeyDown(key))
            {
                Instantiate(n, transform.position, Quaternion.identity, parent.transform);
            }
        }
        else
        {
            if (Input.GetKeyDown(key))
            {
                image.sprite = downSprite;
            }
            if (Input.GetKeyUp(key))
            {
                image.sprite = baseSprite;
            }
            if (Input.GetKeyDown(key) && active)
            {
                Destroy(note);
            }
        }

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;

        if(col.gameObject.tag == "Note")
        {
            note = col.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        active = false;
    }


}
