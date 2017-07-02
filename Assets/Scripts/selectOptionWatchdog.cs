using UnityEngine;
using System.Collections;

public class selectOptionWatchdog : MonoBehaviour {

    public int option;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        if(option == 0 || option == 1 || option == 2)
        {
            //Debug.Log(option);
            OptionsController.player = option;
            //Debug.Log(OptionsController.player);
        }
        
    }
}
