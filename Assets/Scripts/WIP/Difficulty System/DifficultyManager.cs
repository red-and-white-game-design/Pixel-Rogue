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

public class DifficultyManager : Manager {
    public Difficulty difficulty = Difficulty.Lvl0;

    private void Awake() {
        InitManager();
    }
}
