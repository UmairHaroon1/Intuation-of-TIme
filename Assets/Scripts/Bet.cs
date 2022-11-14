using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bet : MonoBehaviour
{
    public List<Image> BetBtn;
   // public List<Image> BG;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void start()
    {
        for (int i = 0; i < BetBtn.Count; i++)
        {
            BetBtn[i].color = Color.clear;
            if (int.Parse(BetBtn[i].name) <= Stars.Instance._Currency)
            {
                BetBtn[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                BetBtn[i].GetComponent<Button>().interactable = false;
            }
        }



    }
    public void ChooseBet(Image IMG) 
    {
        Session.Instance.BetAmount = int.Parse(IMG.gameObject.name);   

        IMG.color = Color.white;
    }
}
      

