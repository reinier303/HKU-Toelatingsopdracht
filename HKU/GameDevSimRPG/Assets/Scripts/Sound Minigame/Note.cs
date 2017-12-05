using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour {

    public ScoreKeeper SK;

    private GameObject Panel;
    Rigidbody2D rb;
    public float speed;
    public Image image;
    public float xpos;

    void Awake()
    {
        image = gameObject.GetComponent<Image>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start()
    {
        Panel = GameObject.Find("ActivatorPanel");

        SK = Panel.GetComponent<ScoreKeeper>();
        xpos = transform.position.x - (Screen.width/2);
        rb.velocity = new Vector2(0, -speed);
        if (xpos == -187.5f)
        {
            image.color = new Color32(255, 100, 100, 240);
        }
        if (xpos == -112.5f)
        {
            image.color = new Color32(255, 255, 150, 240);
        }
        if (xpos == -37.5f)
        {
            image.color = new Color32(170, 255, 170, 240);
        }
        if (xpos == 37.5f)
        {
            image.color = new Color32(170, 220, 255, 240);
        }
        if (xpos == 112.5f)
        {
            image.color = new Color32(255, 190, 90, 240);
        }
        if (xpos == 187.5f)
        {
            image.color = new Color32(255, 150, 255, 240);
        }
    }

    private void Update()
    {
        if (transform.position.y <= -75)
        {
            Destroy(gameObject);
            SK.Energy -= 1;
        }
        if (SK.Energy == 0)
        {
            Destroy(gameObject);
        }
    }
}
