using UnityEngine;
using System.Collections;
using System;

public class columnControllerR : MonoBehaviour {

    public float EP1 = 0;
    public float EP2 = 0;
    public float respawnP = 0;
    bool firstWave = false;
    public float speed = 0;
    Rigidbody2D rb;

    System.Random rnd = new System.Random();

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Start ()
    {
        rb.velocity = new Vector2(0, 0);
    }

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if(firstWave == false)
        {
            if (transform.position.x <= EP1)
            {
                float yPos = (float)rnd.NextDouble() + 3.0f;
                rb.MovePosition(new Vector2(respawnP, yPos));
                firstWave = true;
            }
        }
        else
        {
            if (transform.position.x <= EP2)
            {
                float yPos = (float)rnd.NextDouble() + 3.0f;
                rb.MovePosition(new Vector2(respawnP, yPos));
            }
        }
	    
	}
}
