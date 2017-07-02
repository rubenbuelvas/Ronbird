using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {


    public UnityEngine.UI.Text loadingText;
	// Use this for initialization
	void Start () {
        loadingText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            loadingText.enabled = true;
            Invoke("reloadLevel", 0.5f);
        }
    }

    void reloadLevel()
    {
        SceneManager.LoadScene("Game");
    }

}
