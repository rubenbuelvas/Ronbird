using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour {

    public GameObject optionsScreen;
    public static bool isConfig;
	// Use this for initialization
	void Start () {
        isConfig = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (pj.isPlaying)
        {
            Destroy(gameObject);
        }
	}

    void OnMouseDown()
    {
        isConfig = true;
        GetComponent<AudioSource>().Play();
        pj.isPlaying = false;
        pj.isAlive = false;
        Instantiate(optionsScreen, new Vector3(0, 0, -5), Quaternion.identity);
        
    }
}
