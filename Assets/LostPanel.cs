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
        Stars.Instance.Currency = int.Parse(Scoretext.gameObject.name);
        Scoretext.text = Stars.Instance.name;


    }
}
