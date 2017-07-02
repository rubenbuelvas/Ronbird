using UnityEngine;
using System.Collections;

public class selectOptionWatchdog : MonoBehaviour {

    public int option;
	// Use this for initialization
	void Start ()
    {
        option = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnMouseDown()
    {
        if(option == 0 || option == 1)
        {
            OptionsController.player = option;
        }
        
    }
}
