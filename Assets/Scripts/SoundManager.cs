using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singletion<SoundManager>
{
    public AudioSource MainMenuSound;
    public AudioSource Source;
    // public AudioClip MainMenuClip;
    //public void BtnClick(AudioClip c)
    //{
    //    Source.Play();
    //    DontDestroyOnLoad(gameObject)
    // }
  
    public void Awake()
    {
      
        MuteSound();
    }
    public void MuteSound() 
    {
        int status = PlayerPrefs.GetInt("Sound", 1);
        if (status == 1)
        {
            MainMenuSound.mute = false ;
            Source.mute = false;
        }
        else
        {
            MainMenuSound.mute = true;
            Source.mute = true;

        }
    }
    public void MainmenuSound()
    {
        MainMenuSound.Play();
        Source.Stop();
    }
    public void GameSound()
    {
        Source.Play();
        MainMenuSound.Stop();

    }

}
