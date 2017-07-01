using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class points : MonoBehaviour {

    public Text pointsTxt;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        pointsTxt.text = beers.points.ToString();
	}
}
