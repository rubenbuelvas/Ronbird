using UnityEngine;
using System.Collections;

public class obsGenerator : MonoBehaviour
{
    public GameObject[] obs = new GameObject[5];
    public float secondsToGenerate = 1;
    System.Random rnd = new System.Random();

    // Use this for initialization
    void Start ()
    {
        generate();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void generate()
    {
        int points = pj.points;
        if (pj.isPlaying == true)
        {
            if (points >= 40 - 1)
            {
                Instantiate(obs[4], new Vector2(transform.position.x, ((float)(rnd.Next(-90, 90) / 100.0))), Quaternion.identity);
            }
            else if (points >= 30 - 1)
            {
                Instantiate(obs[3], new Vector2(transform.position.x, ((float)(rnd.Next(-120, 120) / 100.0))), Quaternion.identity);
            }
            else if (points >= 20 - 1)
            {
                Instantiate(obs[2], new Vector2(transform.position.x, ((float)(rnd.Next(-90, 90) / 100.0))), Quaternion.identity);
            }
            else if (points >= 10 - 1)
            {
                Instantiate(obs[1], new Vector2(transform.position.x, ((float)(rnd.Next(-90, 90) / 100.0))), Quaternion.identity);
            }
            else
            {
                Instantiate(obs[0], new Vector2(transform.position.x, ((float)(rnd.Next(-90, 90) / 100.0))), Quaternion.identity);
               // Debug.Log(rnd.Next(-90, 90) / 1000.0);
            }
        }
        Invoke("generate", secondsToGenerate);
    }
}
