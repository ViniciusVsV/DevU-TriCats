using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public static Timer instance;
    float elapsedTime;
    
    void Start()
    {
        elapsedTime = PlayerPrefs.GetFloat("timer", 0);
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);        
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void SaveTime()
    {
        PlayerPrefs.SetFloat("timer", elapsedTime);
        PlayerPrefs.Save();
    }
      
    public void ResetTime()
    {
        PlayerPrefs.DeleteKey("timer");
        elapsedTime = 0;
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
