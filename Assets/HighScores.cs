using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HighScores : MonoBehaviour
{

    public List<int> Scores;
   
    public PlayerScore playerscore;


    void Start()
    {
   
    }

      void Update()
    {
        
    }
    public void OnEnable()
    {
        if (PlayerPrefs.HasKey("highscores"))
        {
        
            JsonUtility.FromJsonOverwrite
            (PlayerPrefs.GetString("highscores"), playerscore);
        }
    }
    public void OnDisable()
    {
        string Key = JsonUtility.ToJson(playerscore);
        PlayerPrefs.SetString("highscores", Key);


    }
}
[Serializable]
public class PlayerScore
{
    public List<int> scores;
  





}

