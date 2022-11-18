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
    public   int _Currency;
    public int Currency
    {
        get 
        {
            return _Currency; 
        }
        set
        {

            _Currency = value;
            Currencytext.text = Currency.ToString();
        }
        
      }

   

    private void Start()
    {
       
    }



    private void OnEnable()
    {
    Currency=PlayerPrefs.GetInt("currency",1000);
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
