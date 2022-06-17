using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Vector2 _screenBounds;
    private int _compteur = 0;
    public GameObject _menu;
    public GameObject FlappyBird;
    public GameObject PlayerDeathAnimation;
   
    


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        CheckOffScreen();
        _screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        CheckOffScreen();
    }

    public void CheckOffScreen()
    {
        if (GameObject.Find("Player").transform.position.y > _screenBounds.y + 1 ||
            GameObject.Find("Player").transform.position.y < -_screenBounds.y - 1)
        {
            _menu.SetActive(true);
            FlappyBird.SetActive(false);
            
            Time.timeScale = 0.5f;
            
            if (ScoreScript.ScoreValue > Best_Score.BestScore)
            {
                Best_Score.BestScore = ScoreScript.ScoreValue;
                savePrefs();
            }
            
            
        }
    }

    private void OnTriggerEnter2D(Collider2D targetObj)
    {

        if (targetObj.gameObject.CompareTag("GameController"))
        {
            ScoreScript.ScoreValue += 1;
           
        
        }
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            GetComponent<JoueurJump>().enabled = false;
            FlappyBird.GetComponent<AudioSource>().enabled = true;
            PlayerDeathAnimation.SetActive(true);
            
           

        }
    }
    
    public void savePrefs()
    {
        PlayerPrefs.SetInt("SavedScore", Best_Score.BestScore);
        PlayerPrefs.Save();
    }

    
}