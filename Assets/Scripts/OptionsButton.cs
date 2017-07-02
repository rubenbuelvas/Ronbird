using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        pj.isPlaying = false;
        pj.isAlive = false;
        SceneManager.LoadScene("Options");
        
    }
}
