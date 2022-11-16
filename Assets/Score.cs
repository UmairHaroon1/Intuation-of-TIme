using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowScore() 
    {
        Debug.Log("text change into int");
        Stars.Instance.Currency = int.Parse(Scoretext.gameObject.name);
        Scoretext.text = Stars.Instance.name;


    }
}
