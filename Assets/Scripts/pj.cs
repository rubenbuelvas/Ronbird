using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pj : MonoBehaviour
{

    public static bool isAlive = true;
    Rigidbody2D rb;
    public static bool isPlaying = false;
    public float upForce = 50;
    public AudioClip deadSound;
    public static int points = 0;
    bool one = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Start ()
    {
        points = 0;
        isAlive = true;
        rb.gravityScale = 0;
        isPlaying = false;
	}

	void Update ()
    {
	    if(isAlive == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isPlaying = true;
                rb.gravityScale = 1;
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * upForce);
                GetComponent<AudioSource>().Play();
            }
        }
	}

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        if(!one)playDeadSound();
        one = true;
        Invoke("chargeScene", 1);
    }

    void playDeadSound()
    {
        GetComponent<AudioSource>().PlayOneShot(deadSound, 1);
    }

    void chargeScene()
    {
        isPlaying = false;
        SceneManager.LoadScene("GameOver");
    }
}
