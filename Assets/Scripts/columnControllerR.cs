using UnityEngine;
using System.Collections;
using System;

public class columnControllerR : MonoBehaviour {

    public float EP1 = 0;
    public float EP2 = 0;
    public float respawnP = 0;
    //bool firstWave = false;
    public float speed = 0;
    Rigidbody2D rb;
    //public GameObject[] obj;
    public static int points = 0;

    //System.Random rnd = new System.Random();

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        points = 0;
    }

    void OnTriggerEnter2D()
    {
        if (pj.isAlive)
        {
            pj.points++;
            if(musicController.selectedMusic == 0)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }

    void Start ()
    {
        //Instantiate(obj[0], new Vector2(1, 1), Quaternion.AngleAxis(180, new Vector3(0, 0, 1)));
        rb.velocity = new Vector2(-speed, 0);
    }

	void Update ()
    {
        if (transform.position.x <= -6)
        {
            Destroy(gameObject);
        }
        /* if (Input.GetMouseButtonDown(0))
         {
             rb.velocity = new Vector2(-speed, 0);

         }*/

        /*if(firstWave == false)
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
        }*/

    }
}
