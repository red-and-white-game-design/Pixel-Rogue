using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public LevelID level;
    public LevelMap levelMap;
    public TimeCounting timeBar;

    public bool started = false;

    private MapTile[,] map;

    public void StartGame() {
        var currentStage = ProgressManager.instance.currentStage;
        var currentLevel = ProgressManager.instance.currentLevel;
        level = ProgressManager.instance.levelID[currentStage][currentLevel];
        levelMap.Init();
        if (DifficultyManager.instance.challengeMode) {
            float timeLimit = ProgressManager.instance.currentStage * 5f + 25f;
            if (ProgressManager.instance.level[currentStage][currentLevel] == LevelType.BossLevel) {
                timeLimit += 20f;
            }
            timeBar.Init(timeLimit);
        } else {
            timeBar.Disable();
        }
        started = true;
    }

    public void PlaceBlock(Brick brick, Vector2 position) {

    }
}
