using UnityEngine;
using System.Collections;

public class musicController : MonoBehaviour {

    public static int selectedMusic;

    public AudioClip[] happyMusic;
    public AudioClip[] sadMusic;
    AudioClip song;
    int songPos;

    System.Random rnd = new System.Random();

    bool one = false;
    // Use this for initialization
    void Start () {
        one = false;
        //selectedMusic = PlayerSelect.selectedMusic;
        //Invoke("updateMusic", 1f);
        songPos = rnd.Next(3);
        selectedMusic = -1;
    }
	
	// Update is called once per frame
	void Update () {
        //selectedMusic = 1;
        if(selectedMusic != 2)
        {
            if (selectedMusic == 0)
            {
                song = happyMusic[songPos];
            }
            else if (selectedMusic == 1)
            {
                song = sadMusic[songPos];
            }
            if (Input.GetMouseButtonDown(0) && !one && selectedMusic != -1)
            {
                GetComponent<AudioSource>().clip = song;
                GetComponent<AudioSource>().loop = true;
                GetComponent<AudioSource>().Play();
                one = true;
            }

            if (!pj.isAlive && musicController.selectedMusic != 1)
            {
                GetComponent<AudioSource>().Stop();
            }
        }
	}
}
