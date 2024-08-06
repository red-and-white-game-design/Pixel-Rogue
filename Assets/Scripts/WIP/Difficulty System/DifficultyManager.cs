using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty {
    Lvl0,
    Lvl1,
    Lvl2,
    Lvl3,
    Lvl4,
    Lvl5,
    Lvl6,
}

public class DifficultyManager : MonoBehaviour {
    public static DifficultyManager instance;
    public Difficulty difficulty = Difficulty.Lvl0;
    public bool challengeMode = false;

    protected void InitManager() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    private void Awake() {
        InitManager();
    }
}
