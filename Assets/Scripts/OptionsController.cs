using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public static int player;
    public static int music;
    public Text loadingText;
    String url;

    void Awake()
    {
        url = Application.persistentDataPath + "/options.dat";
    }

    [Serializable]
    public class OptionsData
    {
        int player;
        int music;

        public void setPlayer(int a)
        {
            this.player = a;
        }

       public int getPlayer()
        {
            return this.player;
        }

        public void setMusic(int a)
        {
            this.music = a;
        }

        public int getMusic()
        {
            return this.music;
        }
    }

	// Use this for initialization
	void Start ()
    {
        loadingText.enabled = false;
	}

    // Update is called once per frame


    void OnMouseDown()
    {
        loadingText.enabled = true;
        GetComponent<AudioSource>().Play();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(url);

        OptionsData data = new OptionsData();
        data.setPlayer(player);
        data.setMusic(music);
       // Debug.Log(music);

        bf.Serialize(file, data);

        file.Close();

        Invoke("restart", 0.5f);
    }

    void restart()
    {
        SceneManager.LoadScene("Game");
    }

    /*int load()
    {
        int maxPoints;
        if (File.Exists(url))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(url, FileMode.Open);

            Data data = (Data)bf.Deserialize(file);

            maxPoints = data.getValue();

            file.Close();
        }
        else
        {
            maxPoints = 0;
        }
        return maxPoints;*/
    }
