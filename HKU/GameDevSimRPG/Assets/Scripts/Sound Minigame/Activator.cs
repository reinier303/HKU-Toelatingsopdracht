using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour
{
    public ScoreKeeper SK;
    public KeyCode Key;

    private bool _active = false;

    GameObject note;

    public Image image;

    public Sprite baseSprite;
    public Sprite downSprite;

    public bool CreateMode;

    public GameObject Parent;
    public GameObject N;

    private void Start()
    {
        SK = GetComponentInParent<ScoreKeeper>();
    }

    // Update is called once per frame
    private void Update ()
    {
        if(CreateMode == true)
        {
            if (Input.GetKeyDown(Key))
            {
                Instantiate(N, transform.position, Quaternion.identity, Parent.transform);
            }
        }
        else
        {
            
            if (Input.GetKeyDown(Key))
            {
                image.sprite = downSprite;
            }
            if (Input.GetKeyUp(Key))
            {
                image.sprite = baseSprite;
            }
            if (Input.GetKeyDown(Key) && _active)
            {
                Destroy(note);
                SK.Score += 100;

                SK.EnergyCounter++;
                
            }
        }

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        _active = true;

        if(col.gameObject.tag == "Note")
        {
            note = col.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        _active = false;
    }


}
