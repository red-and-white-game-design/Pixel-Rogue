using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;

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

    public void LoadSceneByName(string str) {
        SceneManager.LoadScene(str);
    }

    public void GameEnd() {
        PuzzleMap.instance.Check();
    }

    public void GameResult(bool accomplished, int score) {
        if (accomplished) {
            LoadSceneByName("Win Scene");
        } else {
            LoadSceneByName("Lose Scene");
        }
        this.score = score;
    }

    public void Exit() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
