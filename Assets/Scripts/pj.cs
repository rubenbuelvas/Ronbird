using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pj : MonoBehaviour
{

    public static bool isAlive = true;
    Rigidbody2D rb;
    public float upForce = 800;
    public AudioClip deadSound;
    bool one = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Start ()
    {
        isAlive = true;
        rb.gravityScale = 0;
	}

	void Update ()
    {
	    if(isAlive == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.gravityScale = 1;
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
            SceneManager.LoadScene("GameOver");
    }
}
