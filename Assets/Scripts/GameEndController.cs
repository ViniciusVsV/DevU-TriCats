using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndController : MonoBehaviour{
    [SerializeField] private string levelName1;
    [SerializeField] private string levelName2;
    [SerializeField] private string levelName3;
    [SerializeField] private string levelSelector;
    [SerializeField] private string finalScreen;

    public void ChangeScene(){
        if(PlayerPrefs.GetInt(levelName1) == 1)
        {
           SceneManager.LoadScene(finalScreen);
           Timer.instance.SaveTime();
        }
        else
            SceneManager.LoadScene(levelSelector);
    }
}