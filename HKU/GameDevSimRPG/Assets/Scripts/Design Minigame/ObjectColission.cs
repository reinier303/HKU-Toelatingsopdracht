using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColission : MonoBehaviour {

    public Vector2 startPosition = new Vector2(0.1f, 6f);
    private GameObject player;
    private DesignScoreKeeper DSK;

    void Awake()
    {
        player = GameObject.Find("Player");
        DSK = GameObject.Find("Canvas").GetComponent<DesignScoreKeeper>(); ;
    }
    
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            player.transform.position = startPosition;
            DSK.Energy--;
        }
    }
}
