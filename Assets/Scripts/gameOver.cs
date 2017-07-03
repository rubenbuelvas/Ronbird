using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {

    public Text points;
    //public Text text1, text2;

    public Text loadingText;
	// Use this for initialization
	void Start () {
        loadingText.enabled = false;
        if(musicController.selectedMusic == 1)
        {
            GetComponent<AudioSource>().Stop();
        }
        points.text = pj.points.ToString();
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
