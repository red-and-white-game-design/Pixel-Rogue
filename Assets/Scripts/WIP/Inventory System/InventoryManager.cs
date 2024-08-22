using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    public static InventoryManager instance;
    public List<BrickID> brick = new();
    public int reverseCount;
    public int starCount;
    public int coinCount;
    public int formulationSize;
    public int coinStarRatio;
    public List<int> lastSelection = new();

    private void InitManager() {
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

    public void AddBrick(BrickID brickID) {
        brick.Add(brickID);
    }

    public void DeleteBrick(BrickID brickID) {
        brick.Remove(brickID);
    }

    public void SetReverseCount(int value) {
        reverseCount = value;
    }

    public void SetStarCount(int value) {
        starCount = value;
    }

    public void SetCoinCount(int value) {
        coinCount = value;
    }

    public void SetFormulationSize(int value) {
        formulationSize = value;
    }

    public void Clear() {
        brick.Clear();
        reverseCount = 0;
        starCount = 0;
        coinCount = 0;
        formulationSize = 0;
        coinStarRatio = 3;
    }

    public void Init() {
        Clear();
        reverseCount = 1;
        starCount = 0;
        coinCount = 3;
        formulationSize = 6;
        coinStarRatio = 3;
        if ((int)DifficultyManager.instance.difficulty >= 1) {
            coinStarRatio *= 2;
        }
        if ((int)DifficultyManager.instance.difficulty >= 2) {
            coinCount--;
        }
        if ((int)DifficultyManager.instance.difficulty >= 3) {
            coinStarRatio++;
        }
        if ((int)DifficultyManager.instance.difficulty >= 5) {
            coinCount--;
        }
        if ((int)DifficultyManager.instance.difficulty >= 6) {
            formulationSize--;
        }
    }
}
