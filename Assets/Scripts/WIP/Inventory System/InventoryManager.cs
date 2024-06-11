using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : Manager {
    public List<Brick> bricks;
    public int reverseCount;
    public int starCount;
    public int coinCount;
    public int formulationSize;

    private void Awake() {
        InitManager();
    }

    public void AddBrick(Brick brick) {
        bricks.Add(brick);
    }

    public void DeleteBrick(Brick brick) {
        bricks.Remove(brick);
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
}
