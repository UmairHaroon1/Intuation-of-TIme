using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicSound : MonoBehaviour
{
   private void Start()
   {
      GetComponent<Button>().onClick.AddListener(Soun);
   }

   void Soun()
   {
      SoundManager.Instance.Play(SoundManager.Instance.Button);
   }
}
