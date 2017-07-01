using UnityEngine;
using System.Collections;

public class beers : MonoBehaviour
{
    public static int points = 0;

    void Awake()
    {
        points = 0;
    }

	void OnTriggerEnter2D()
    {
        points++;
        GetComponent<AudioSource>().Play();
    }

	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	
	}
}
