using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour {

    public Text loadingText;
    //public Text continueText;
    // Use this for initialization
    void Start()
    {
        //loadingText.enabled = false;
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            continueText.enabled = false;
            loadingText.enabled = true;
            SceneManager.LoadScene("Game");
        }*/
    }
}
