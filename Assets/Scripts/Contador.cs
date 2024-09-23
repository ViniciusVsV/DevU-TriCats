using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;

    void Start()
    {
        float tempo;
        
        tempo = PlayerPrefs.GetFloat("timer", 0);
        
        int minutes = Mathf.FloorToInt(tempo / 60);        
        int seconds = Mathf.FloorToInt(tempo % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
