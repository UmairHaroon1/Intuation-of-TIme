using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    public TextMeshProUGUI Coficient;
    public TextMeshProUGUI Win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        ShowScore();
    }

   
    public void ShowScore() 
    {
        Debug.Log("text change into int");
      
    Scoretext.text = Session.Instance.BetAmount.ToString();
        Coficient.text = Mathf.Round(Ball.Instance.score).ToString();
        float winam = Session.Instance.BetAmount * Mathf.Round(Ball.Instance.score);
        winam = Mathf.Round(winam);
        Win.text = winam.ToString();
        HighScores.Instance.playerscore.scores.Add((int)winam);
        Session.Instance.BetAmount = 0;

    }
}
