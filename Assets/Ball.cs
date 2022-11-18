using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Instance;
    public Transform T;
    public float Speed;
    public TextMeshProUGUI UIText;
    public float score;
    public bool Stop;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        SoundManager.Instance.Play(SoundManager.Instance.FlewAway);
        BackgroundLoop.Instance.Toggle(true);
        score = 0;
    }

    private void Update()
    {
        if(Stop) return;
        if (transform.position == T.position)
        {
            Stop = true;
            CanvasManager.Instanve.OnGameOver();
            return;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, T.position, Time.deltaTime * Speed);
        score += 2*Time.deltaTime;
        UIText.text = $"x{Mathf.Round(score)}";
    }
}
