using UnityEngine;
using System.Collections;

public class obsGenerator : MonoBehaviour
{
    public GameObject[] obs = new GameObject[5];
    public float secondsToGenerate = 1;
    System.Random rnd = new System.Random();
    int c = 0;

    // Use this for initialization
    void Start ()
    {
        c = 0;
        generate();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void generate()
    {
        
      
        if (pj.isPlaying == true)
        {
            if (c > 40 - 1)
            {
                c++;
                Instantiate(obs[4], new Vector2(transform.position.x, ((float)(rnd.Next(-165, 165) / 100.0))), Quaternion.AngleAxis(180, new Vector3(0, 0, 1)));
            }
            else if (c > 30 - 1)
            {
                c++;
                Instantiate(obs[2], new Vector2(transform.position.x, ((float)(rnd.Next(-130, 130) / 100.0))), Quaternion.AngleAxis(180, new Vector3(0, 0, 1)));
            }
            else if (c > 20 - 1)
            {
                c++;
                Instantiate(obs[3], new Vector2(transform.position.x, ((float)(rnd.Next(-90, 90) / 100.0))), Quaternion.AngleAxis(180, new Vector3(0, 0, 1)));
            }
            else if (c > 10 - 1)
            {
                c++;
                Instantiate(obs[1], new Vector2(transform.position.x, ((float)(rnd.Next(-120, 120) / 100.0))), Quaternion.AngleAxis(180, new Vector3(0, 0, 1)));
            }
            else
            {
                c++;
                Instantiate(obs[0], new Vector2(transform.position.x, ((float)(rnd.Next(-90, 90) / 100.0))), Quaternion.AngleAxis(180, new Vector3(0, 0, 1)));
               // Debug.Log(rnd.Next(-90, 90) / 1000.0);
            }

            if(c >= 50 - 1)
            {
                c = 20 - 1;
            }
        }
        Invoke("generate", secondsToGenerate);
    }
}
