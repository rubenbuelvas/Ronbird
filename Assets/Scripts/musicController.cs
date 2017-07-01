using UnityEngine;
using System.Collections;

public class musicController : MonoBehaviour {
    bool one = false;
    // Use this for initialization
    void Start () {
        one = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && !one)
        {
            GetComponent<AudioSource>().Play();
            one = true;
        }

        if (!pj.isAlive)
        {
            GetComponent<AudioSource>().Stop();
        }
	}
}
