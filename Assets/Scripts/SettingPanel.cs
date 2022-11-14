using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{
    public List<GameObject> Sound;
    public List<GameObject> Language;
    public List<GameObject> Vibration;
    public Image SoundSprite;
    public Image languageSprites;
    public Image VibrationSprites;
   
    private void OnEnable()
    {
        Sound.ForEach(x => x.SetActive(false));
        Sound[PlayerPrefs.GetInt("Sound",1)].SetActive(true) ;
        Vibration.ForEach(x => x.SetActive(false));
        Vibration[PlayerPrefs.GetInt("Vibration", 1)].SetActive(true);
        Language.ForEach(x => x.SetActive(false));
        Debug.Log(PlayerPrefs.GetInt("Language", 1));
        Language[PlayerPrefs.GetInt("Language", 1)].SetActive(true);
       

    }


    public void ToggleSoound()
    {
        int status = PlayerPrefs.GetInt("Sound",1);

        if (status == 1)
        {
            status = 0;

            Sound[0].SetActive(true);
            Sound[1].SetActive(false);
        }
        else
        {
            status = 1;
            Sound[1].SetActive(true);
            Sound[0].SetActive(false);

        }
       // SoundManager.Instance.MainmenuSound();
        PlayerPrefs.SetInt("Sound",status);
        SoundManager.Instance.MuteSound();


    }
    public void ToggleLanguage(int a)
    {
        if (a == 1)
        { 
            a = 1;
           
            Language[1].SetActive(true);
            Language[0].SetActive(false);
          
            
        }
        else
        {
            a = 0;
            Language[0].SetActive(true);
            Language[1].SetActive(false);
           
        }

        PlayerPrefs.SetInt("Language", a);
        ChangeLanguage.Instance.changelanguage();
    }
    public void ToggleVibration()
    {

        int status = PlayerPrefs.GetInt("Vibration", 1);

        if (status == 1)
        {
            status = 0;

            Vibration[0].SetActive(true);
            Vibration[1].SetActive(false);
        }
        else
        {
            status = 1;
            Vibration[1].SetActive(true);
            Vibration[0].SetActive(false);
        }
        PlayerPrefs.SetInt("Vibration", status);
    }

}
