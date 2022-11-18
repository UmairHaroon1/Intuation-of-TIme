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
    private void Awake()
    {
        Instanve = this;
    }
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
        SoundManager.Instance.Play(SoundManager.Instance.Button);
        MainMenu.Hide();
        Settingpanel.Hide();
        Betpanel.Show();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();

        

    }
    public void SettingBtnClicked()
    {
        SoundManager.Instance.Play(SoundManager.Instance.Button);
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
        SoundManager.Instance.Play(SoundManager.Instance.Button);
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
        SoundManager.Instance.Play(SoundManager.Instance.Button);

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
        Fade.Instance.LoadScene("MainMenu");
    }
    public void RestartBtnClicked()
    {
        Session.Instance.Replay = true;
        Fade.Instance.LoadScene("MainMenu");


    }

    public void OnClickGamePlay()
    {
        SoundManager.Instance.GameSound();

        SoundManager.Instance.Play(SoundManager.Instance.Button);
        Stars.Instance.Currency -= Session.Instance.BetAmount;
        Betpanel.Hide();
        GamePlay.ForEach(x=>x.SetActive(true));
        StartPanel.Show();
    }

    public void OnGameOver()
    {
        SoundManager.Instance.Play(SoundManager.Instance.Button);
        LostPanel.Show();
        GamePlay.ForEach(x=>x.SetActive(false));
        StartPanel.Hide();
    }public void OnTake()
    {
        SoundManager.Instance.Play(SoundManager.Instance.Button);
        Scorepanel.Show();
        GamePlay.ForEach(x=>x.SetActive(false));
        StartPanel.Hide();
    }
    void Restrt()
    {
        SoundManager.Instance.Play(SoundManager.Instance.Button);
        MainMenu.Hide();
        Settingpanel.Hide();
        Betpanel.Show();
        StartPanel.Hide();
        Scorepanel.Hide();
        BestIndicaor.Hide();
        LostPanel.Hide();

     

    }
}