using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguage: MonoBehaviour
{
   public static ChangeLanguage Instance;
   public List<Image> ImageChange;
   public List<Sprite> ENG;
   public List<Sprite> RUS;


    private void Awake()
   {
      Instance = this;
      changelanguage();
        
   }
   

   public void changelanguage()
   {
      int Stataus = PlayerPrefs.GetInt("Language", 1);
      for (int i = 0; i < ImageChange.Count; i++)
      {
         if (Stataus == 0)
         {
                

            ImageChange[i].sprite = RUS[i];
         }
         else
         {
                               
            ImageChange[i].sprite = ENG[i];


         }
         
      }
   }
}
