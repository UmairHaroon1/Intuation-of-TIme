using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HighScores : MonoBehaviour
{

    public List<int> Scores;
    public int Win;
    public PlayerScore playerscore;


    // Start is called before the first frame update
    void Start()
    {
        Scores.Add(Win);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnable()
    {
        if (PlayerPrefs.HasKey("highscores"))
        {
            //string Key = JsonUtility.ToJson(playerscore);
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

