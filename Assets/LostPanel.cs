using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LostPanel : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    private void OnEnable()
    {
        ShowScore();
    }

   
    public void ShowScore() 
    {
        Debug.Log("text change into int");

        Scoretext.text = Session.Instance.BetAmount.ToString();


    }
}
