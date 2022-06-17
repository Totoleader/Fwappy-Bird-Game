using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainMenu;
 
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScript.ScoreValue = 0;
        MainMenu.SetActive(false);
        

    }
}