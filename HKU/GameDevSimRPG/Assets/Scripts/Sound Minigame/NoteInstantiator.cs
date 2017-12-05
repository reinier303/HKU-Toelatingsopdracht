using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteInstantiator : MonoBehaviour {

    public GameObject Note;
    public GameObject NotePanel;
    public float BPM;
    private float Timer;
    private float xpos;
    public float spawnHeight;


	// Use this for initialization
	void Start () {
        BPM = (60 / BPM);
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
            Note = Instantiate(Note, new Vector3(xpos + (Screen.width/2), spawnHeight, 0), transform.rotation, NotePanel.transform)as GameObject;
            Timer = BPM;
        }

    }




}
