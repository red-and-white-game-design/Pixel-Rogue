using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick {
    Vector2Int size = new(0, 0);
    bool[,] pattern = new bool[0, 0];
    bool[,] patternReversed = new bool[0, 0];

    public bool[,] GetPattern(bool isReversed) {
        if (isReversed) {
            return patternReversed;
        } else {
            return pattern;
        }
    }

    static public Brick Gen(Vector2Int _size, string[] _pattern) {
        Brick brick = new();
        brick.size = _size;
        brick.pattern = new bool[_size.x, _size.y];
        for (int i = 0; i < _size.x && i < _pattern.Length; i++) {
            for (int j = 0; j < _size.y && j < _pattern[i].Length; j++) {
                brick.pattern[i, j] = _pattern[i][j] == '1';
                if (_pattern[i][j] != '1' && _pattern[i][j] != '0') {
                    Debug.LogError($"Reading pattern char out of range!");
                }
            }
        }
        brick.patternReversed = new bool[_size.x, _size.y];
        for (int i = 0; i < _size.x; i++) {
            for (int j = 0; j < _size.y; j++) {
                brick.patternReversed[i, _size.y - j - 1] = brick.pattern[i, j];
            }
        }

        return brick;
    }
}