using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject BestIndicaor;
    public GameObject Settingpanel;
    public GameObject Betpanel;
    public GameObject StartPanel;
    public GameObject Scorepanel;
    public GameObject LostPanel;
    // Start is called before the first frame update
    void Start()
    {
       SoundManager.Instance.MainmenuSound();  
        MainMenu.Show(true);
        Settingpanel.Hide();
        Betpanel.Hide();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();
    }
    public void StartBtnClicked()
    {
        MainMenu.Hide();
        Settingpanel.Hide();
        Betpanel.Show(true);
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();

        SoundManager.Instance.GameSound();

    }
    public void SettingBtnClicked()
    {
        MainMenu.Hide();
        Settingpanel.Show(true);
        Betpanel.Hide();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();
    }
    public void bestindicatorBtnClicked()
    {
        MainMenu.Hide();
        Settingpanel.Hide();
        Betpanel.Hide();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Show(true);
        LostPanel.Hide();
    }
    public void BackBtnClicked()
    {
        MainMenu.SetActive(true);
        Settingpanel.SetActive(false);
        Betpanel.SetActive(false);
        StartPanel.SetActive(false);
        Scorepanel.SetActive(false);
        BestIndicaor.SetActive(false);
        LostPanel.SetActive(false);
    }
}
