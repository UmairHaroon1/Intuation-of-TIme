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
        Stars.Instance.Currency = int.Parse(Scoretext.gameObject.name);
        Scoretext.text = Stars.Instance.name;


    }
}
