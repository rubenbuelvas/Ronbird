using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

    public UnityEngine.UI.Text loadingText;
    // Use this for initialization
    void Start()
    {
        loadingText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            loadingText.enabled = true;
            SceneManager.LoadScene("Game");
        }
    }
}
