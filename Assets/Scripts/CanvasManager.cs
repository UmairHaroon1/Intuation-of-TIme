using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instanve;
    public GameObject MainMenu;
    public GameObject BestIndicaor;
    public GameObject Settingpanel;
    public GameObject Betpanel;
    public GameObject StartPanel;
    public GameObject Scorepanel;
    public GameObject LostPanel;

    public List<GameObject> GamePlay;
    //  private object scenemanagerr;

    // Start is called before the first frame update
    void Start()
    {
        if (Session.Instance.Replay)
        {
            Session.Instance.Replay = false;
            Restrt();
            return;
        }
        SoundManager.Instance.MainmenuSound();
        MainMenu.Show();
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
        Betpanel.Show();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();

        SoundManager.Instance.GameSound();

    }
    public void SettingBtnClicked()
    {
        MainMenu.Hide();
        Settingpanel.Show();
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
        BestIndicaor.Show();
        LostPanel.Hide();
    }

 //   public Button b;
    public void BackBtnClicked()
    {

        MainMenu.Show();
        Settingpanel.Hide();
        Betpanel.Hide();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();
    }
    public void SceneReload()
    {

    }
    public void RestartBtnClicked()
    {
        Session.Instance.Replay = true;
        Fade.Instance.LoadScene("Game");


    }

    public void OnClickGamePlay()
    {
        Betpanel.Hide();
        GamePlay.ForEach(x=>x.SetActive(true));
        StartPanel.Show();
    }

    public void OnGameOver()
    {
        LostPanel.Show();
        GamePlay.ForEach(x=>x.SetActive(false));
        StartPanel.Hide();
    }public void OnTake()
    {
        Scorepanel.Show();
        GamePlay.ForEach(x=>x.SetActive(false));
        StartPanel.Hide();
    }
    void Restrt()
    {
        MainMenu.Hide();
        Settingpanel.Hide();
        Betpanel.Show();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();

     

    }
}