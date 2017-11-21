using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteInstantiator : MonoBehaviour {

    public GameObject Note;
    public GameObject NotePanel;
    public float BPM;
    public float Timer;
    public float xpos;

	// Use this for initialization
	void Start () {
        Timer = BPM;
	}
	
	// Update is called once per frame
	void Update () {
        int random = Random.Range(0, 6);
        switch (random)
        {
            case 0:
                xpos = -187.5f;
                break;
            case 1:
                xpos = -112.5f;
                break;
            case 2:
                xpos = -37.5f;
                break;
            case 3:
                xpos = 37.5f;
                break;
            case 4:
                xpos = 112.5f;
                break;
            case 5:
                xpos = 187.5f;
                break;
        }
        Timer -= Time.deltaTime;
        if(Timer <= 0)
        {
            Note = Instantiate(Note, new Vector3(xpos + (Screen.width/2), 800, 0), transform.rotation, NotePanel.transform)as GameObject;
            ChangeColor();
            Timer = BPM;
        }
    }

    void ChangeColor()
    {
        Image noteImage = Note.GetComponent<Image>();

        if (xpos == -187.5f)
        {
            noteImage.color = new Color32(255, 100, 100, 240);
        }
        if (xpos == -112.5f)
        {
            noteImage.color = new Color32(255, 255, 150, 240);
        }
        if (xpos == -37.5f)
        {
            noteImage.color = new Color32(170, 255, 170, 240);
        }
        if (xpos == 37.5f)
        {
            noteImage.color = new Color32(170, 220, 255, 240);
        }
        if (xpos == 112.5f)
        {
            noteImage.color = new Color32(255, 190, 90, 240);
        }
        if (xpos == 187.5f)
        {
            noteImage.color = new Color32(255, 150, 255, 240);
        }
    }
}
