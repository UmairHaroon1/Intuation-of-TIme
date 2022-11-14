using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bet : MonoBehaviour
{
    public List<Image> BetBtn;
   

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
        for (int i = 0; i < BetBtn.Count; i++)
        {
            BetBtn[i].color = Color.clear;
            Debug.Log("Button is clear");
            if (int.Parse(BetBtn[i].gameObject.name) <= Stars.Instance._Currency)
            {
                BetBtn[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                BetBtn[i].GetComponent<Button>().interactable = false;
            }
            
        }



    }
    public void ChooseBet(Image img) 
    {
        
        Session.Instance.BetAmount = int.Parse(img.gameObject.name);
        img.color = Color.white;
        Debug.Log("Button is White");

    }
}
      

