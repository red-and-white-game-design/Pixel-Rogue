using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty {
    Lvl0 = 0,
    Lvl1 = 1,
    Lvl2 = 2,
    Lvl3 = 3,
    Lvl4 = 4,
    Lvl5 = 5,
    Lvl6 = 6,
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
