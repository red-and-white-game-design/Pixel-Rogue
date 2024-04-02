using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetris {
    public int count;
    public Vector2Int size;
    public bool[,] map;
    public Vector2 center => new Vector2(size.y - 1, size.x - 1) * 0.5f;

    public Tetris() {
        count = 0;
        size = new(0, 0);
        map = new bool[0, 0];
    }
    public Tetris(int[,] _map) {
        int cnt = 0;
        foreach (var x in _map) {
            if (x == 1) {
                cnt++;
            }
        }
        count = cnt;
        size = new(_map.GetLength(0), _map.GetLength(1));
        map = new bool[size.x, size.y];
        for (int i = 0; i < size.x; i++) {
            for (int j = 0; j < size.y; j++) {
                map[i, j] = _map[i, j] == 1;
            }
        }
    }
    public static List<Tetris> GetList(int tier) {
        List<Tetris> list = new();
        switch (tier) {
            case 1:
                list.Add(new TetrisA1());
                break;
            case 2:
                list.Add(new TetrisB1());
                break;
            case 3:
                list.Add(new TetrisC1());
                list.Add(new TetrisC2());
                break;
            case 4:
                list.Add(new TetrisD1());
                list.Add(new TetrisD2());
                list.Add(new TetrisD3());
                list.Add(new TetrisD4());
                list.Add(new TetrisD5());
                list.Add(new TetrisD6());
                list.Add(new TetrisD7());
                break;
            case 5:
                list.Add(new TetrisE1());
                list.Add(new TetrisE2());
                list.Add(new TetrisE3());
                list.Add(new TetrisE4());
                list.Add(new TetrisE5());
                list.Add(new TetrisE6());
                list.Add(new TetrisE7());
                list.Add(new TetrisE8());
                list.Add(new TetrisE9());
                list.Add(new TetrisE10());
                list.Add(new TetrisE11());
                list.Add(new TetrisE12());
                list.Add(new TetrisE13());
                list.Add(new TetrisE14());
                list.Add(new TetrisE15());
                list.Add(new TetrisE16());
                list.Add(new TetrisE17());
                list.Add(new TetrisE18());
                break;
            case 6:
                list.Add(new TetrisS1());
                list.Add(new TetrisS2());
                list.Add(new TetrisS3());
                break;
            default:
                break;
        }
        return list;
    }

    public static Tetris GetRandom(int tier) {
        var list = GetList(tier);
        return list[Random.Range(0, list.Count)];
    }
}
