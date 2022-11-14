using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Stars : MonoBehaviour
{
    public static Stars Instance;
   // public GameObject StarText;
   // public int  Currency;
    public TextMeshProUGUI Currencytext;
    public   int Currency;
    public int _Currency
    {
        get 
        {
            return Currency; 
        }
        set
        {

            Currency = value;
            Currencytext.text = Currency.ToString();
        }
        
      }

   

    private void Start()
    {
       
    }



    private void OnEnable()
    {
    PlayerPrefs.GetInt("currency",1000);
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("currency",Currency);
    }
    public void Awake()
    {
        Instance = this;
    }
}
