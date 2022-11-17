using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HighScores : MonoBehaviour
{

    public List<int> Scores;
  
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
[Serializable]
public class PlayerScore : MonoBehaviour
{
    public PlayerScore playerscore;
    public List<int> scores;
   public void OnEnable()
    {
        if (PlayerPrefs.HasKey("highscores")) 
        {
            string Key = JsonUtility.ToJson(playerscore);
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("highscores", playerscore);             
        
        }
    }
    public void OnDisable()
    {
        string Key = JsonUtility.ToJson(playerscore);
        PlayerPrefs.SetString("highscores", Key);


    }





}

