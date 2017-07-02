using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerSelect : MonoBehaviour
{
    public GameObject[] players;
    int selectedPlayer;


    String url;

    void Awake()
    {
        url = Application.persistentDataPath + "/options.dat";

    }
        // Use this for initialization
    void Start ()
    {
        //int selectedPlayer;
        if (File.Exists(url))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(url, FileMode.Open);

            OptionsController.OptionsData data = (OptionsController.OptionsData)bf.Deserialize(file);

            selectedPlayer = data.getPlayer();

            file.Close();
        }
        else
        {
            selectedPlayer = 0;
        }

        Instantiate(players[selectedPlayer], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
