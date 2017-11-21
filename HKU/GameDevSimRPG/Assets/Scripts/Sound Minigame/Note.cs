using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start()
    {
        rb.velocity = new Vector2(0, -speed);
    }

    void Update()
    {
        if(transform.position.y <= -100)
        {
            Destroy(gameObject);
        }
    }
}
