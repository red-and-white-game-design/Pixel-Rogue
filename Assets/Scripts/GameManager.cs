using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Start() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }

    public void GameEnd() {
        PuzzleMap.instance.Check();
    }

    public void GameResult(bool accomplished, int score) {

    }
}
