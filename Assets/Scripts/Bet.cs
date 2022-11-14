using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bet : MonoBehaviour
{
    public List<Image> BetBtn;
    public List<Image> OffBtn;
    public List<Button> betbtn;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        betbtn[0].interactable = false;
        for (int i = 0; i < BetBtn.Count; i++)
        {
            BetBtn[i].color = Color.clear;
            Debug.Log("Button is clear");
            if (int.Parse(BetBtn[i].gameObject.name) <= Stars.Instance._Currency)
            {
                BetBtn[i].GetComponent<Button>().interactable = true;
                OffBtn[i].color = Color.white;
               // betbtn[0] = betbtn[1];

            }
            else
            {
                BetBtn[i].GetComponent<Button>().interactable = false;
                OffBtn[i].color = Color.red;
               
            }
           
            
        }



    }
    public void ChooseBet(Image img)
    {
        betbtn[0].interactable = true;

        for (int a = 0; a < BetBtn.Count; a++)
        {
            BetBtn[a].color = Color.clear;
    
        }
        Session.Instance.BetAmount = int.Parse(img.gameObject.name);
        Debug.Log("Button is White");
        img.color = Color.white;
       
    }

}
      

