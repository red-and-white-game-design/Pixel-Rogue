using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        var score = GameManager.instance.score;
        if (score != 0) {
            scoreText.text = (GameManager.instance.score * 100).ToString();
        } else {
            scoreText.text = "000";
        }

    }
}
