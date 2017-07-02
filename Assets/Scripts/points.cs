using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class points : MonoBehaviour {

    public Text pointsTxt;
    public Text maxPointsNumber;
    public Text maxPointsText;

    //public static points points_;
    String url;



	// Use this for initialization
	void Start () {
        pointsTxt.enabled = false;
        url = Application.persistentDataPath + "/data.dat";
        maxPointsNumber.text = load().ToString();
	}


    bool one = false;
	// Update is called once per frame
	void Update () {

        if (pj.isPlaying && !one)
        {
            one = true;
            pointsTxt.enabled = true;
            maxPointsNumber.enabled = false;
            maxPointsText.enabled = false;
        }
        pointsTxt.text = pj.points.ToString();

        if (OptionsButton.isConfig && !one)
        {
            one = true;
            maxPointsNumber.enabled = false;
            maxPointsText.enabled = false;
        }

        if (!pj.isAlive)
        {
            pointsTxt.enabled = false;
        }
	}

    int load()
    {
        int maxPoints;
        if (File.Exists(url))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(url, FileMode.Open);

            pj.Data data = (pj.Data)bf.Deserialize(file);

            maxPoints = data.getValue();

            file.Close();
        }
        else
        {
            maxPoints = 0;
        }
        return maxPoints;
    }

    
}
