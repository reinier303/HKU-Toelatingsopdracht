using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstantiator : MonoBehaviour {

    public GameObject Note;
    public GameObject NotePanel;
    public float BPM;
    public float Timer;
    private float xpos;

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
            Timer = BPM;
        }
    }
}
