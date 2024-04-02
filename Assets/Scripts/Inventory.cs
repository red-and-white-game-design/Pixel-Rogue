using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public static Inventory instance;

    public Tetris[] tetris;
    public int[] useTime;
    public int flipTime;

    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
        Init();
    }

    public void Init() {
        tetris = new Tetris[5] {
            Tetris.GetRandom(1),
            Tetris.GetRandom(2),
            Tetris.GetRandom(4),
            Tetris.GetRandom(4),
            Tetris.GetRandom(5),
        };
        useTime = new int[5] {
            1,
            1,
            1,
            1,
            1,
        };
        flipTime = 2;
    }

    void Update()
    {
        
    }

    public bool CanUse(int num) {
        return useTime[num] > 0;
    }

    public void Use(int num) {
        useTime[num]--;
    }

    public void UseFlip() {
        flipTime--;
    }

    public bool CanUseFlip() {
        return flipTime > 0;
    }
}
