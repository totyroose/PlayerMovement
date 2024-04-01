using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager inst;
    public Text scoreText;
    int score = 0; 


    void  Awake()
    {
        inst = this; 
    }

    // Update is called once per frame
   public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE : " + score.ToString();
    }
}
