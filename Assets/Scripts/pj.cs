using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class pj : MonoBehaviour
{

    public static bool isAlive = true;
    Rigidbody2D rb;
    public static bool isPlaying = false;
    public float upForce = 50;
    public AudioClip deadSound;
    public static int points = 0;
    bool one = false;
    String url;

    void Awake()
    {
        url = Application.persistentDataPath + "/data.dat";
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
        int temp = load();
        if(points > temp)
        {
            save(points);
        }
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

    void save(int p)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(url);

        Data data = new Data();
        data.setValue(p);

        bf.Serialize(file, data);

        file.Close();
    }

    int load()
    {
        int maxPoints;
        if (File.Exists(url))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(url, FileMode.Open);

            Data data = (Data)bf.Deserialize(file);

            maxPoints = data.getValue();

            file.Close();
        }
        else
        {
            maxPoints = 0;
        }
        return maxPoints;
    }


    [Serializable]
    public class Data
    {
        int maxPointsSaved;

        public void setValue(int max)
        {
            this.maxPointsSaved = max;
        }

        public int getValue()
        {
            return this.maxPointsSaved;
        }
    }
}
