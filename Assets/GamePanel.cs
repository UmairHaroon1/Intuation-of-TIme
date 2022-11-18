using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GamePanel : MonoBehaviour
{
    public List<TextMeshProUGUI> Pos;
    private void OnEnable()
    {
        HighScores.Instance.playerscore.scores =
            HighScores.Instance.playerscore.scores.OrderByDescending(x => x).ToList();
        for (int i = 0; i < Pos.Count; i++)
        {
            if (i < HighScores.Instance.playerscore.scores.Count)
            {
                Pos[i].text = $"x{HighScores.Instance.playerscore.scores[i]}";

            }
            else
            {
                Pos[i].text = "X00";
            }
        }
    }

    public void OnClickTake()
    {
        SoundManager.Instance.Play(SoundManager.Instance.Button);
        Ball.Instance.Stop = true;
        CanvasManager.Instanve.OnTake();
    }
}
