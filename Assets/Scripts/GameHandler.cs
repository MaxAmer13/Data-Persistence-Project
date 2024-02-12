using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;




public class GameHandler : MonoBehaviour
{
    public static GameHandler instance;

    public string player;

    public int score;

    public static List<TopGame> topGames = new List<TopGame>();





    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadElement();
    }



    [System.Serializable]
    public class TopGame
    {
        public string topPlayer;
        public int topScore;
        
    }


    [System.Serializable]
    public class SaveData
    {
        
        public string player;
        public int highScore;
        public List<TopGame> BestScores;

    }



    public void SaveElement()
    {

        SaveData data = new SaveData();

        data.player = player;
        data.highScore = score;
        data.BestScores = topGames;

        string path = Application.persistentDataPath + "/savefile.json";

        // Convert the list of SaveData objects to JSON format
        string json =  JsonUtility.ToJson(data);

        
        Debug.Log(json);

        
        Debug.Log(path);
            
        File.WriteAllText(path,json);
             

            
        
            
    }


    public void LoadElement()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            player = data.player;
            score = data.highScore;
            topGames = data.BestScores;
        }

    }
}
