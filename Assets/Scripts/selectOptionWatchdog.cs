using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectOptionWatchdog : MonoBehaviour {

    public Text txt;
    public int option;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (OptionsController.music != option - 3 && OptionsController.player != option)
        {
            txt.color = Color.gray;
        }
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        if(option <= 2)
        {
            //Debug.Log(option);
            OptionsController.player = option;
            txt.color = Color.red;
            //Debug.Log(OptionsController.player);
        }
        else if(option >= 3)
        {
            OptionsController.music = option - 3;
            txt.color = Color.red;
            
        }
        
    }
}
