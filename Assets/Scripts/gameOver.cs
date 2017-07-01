using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainSc");
        }
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainSc");
        }
    }

}
