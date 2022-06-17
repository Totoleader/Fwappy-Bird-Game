using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch_Game : MonoBehaviour
{

    private static Boolean MainMenuIsActive = true;
    public GameObject MainMenu;
    public GameObject FlappyBird;
    public GameObject ScoreUI;
    

    void Start()
    {
      



        // Best_Score.BestScore = PlayerPrefs.GetInt("SavedScore");
        
        
        if (MainMenuIsActive)
        {
            DontDestroyOnLoad(GetComponent<AudioSource>());
            DontDestroyOnLoad(GetComponent<AudioListener>());
            MainMenuIsActive = false;
            FlappyBird.SetActive(false);
            ScoreUI.SetActive(false); 
            GetComponent<AudioSource>().enabled = true;
            GetComponent<AudioListener>().enabled = true;
            
            loadPrefs();
        }
        
        else if (MainMenuIsActive == false)
        {
            MainMenu.SetActive(false);
            GetComponent<NewObstacle>().enabled = true;
        }
    }

    private int GetSavedScore(string keyName)
    {
        return PlayerPrefs.GetInt(keyName);
    }

    
    
    public void loadPrefs()
    {
        var Score = PlayerPrefs.GetInt("SavedScore", 0);
        Best_Score.BestScore = Score;
    }
}
