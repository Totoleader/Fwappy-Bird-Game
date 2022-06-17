using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Best_Score : MonoBehaviour
{
    public static int BestScore = 0;
   
    private Text Best_score;
   
    void Start()
    {
        Best_score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Best_score.text = "" + BestScore;
    }
}


