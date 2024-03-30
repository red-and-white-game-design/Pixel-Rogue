using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisPrefab : MonoBehaviour {
    public GameObject TetrisTilePrefab;
    Tetris tetris;
    TetrisTile[,] map;

    public void Init(Tetris _tetris, bool resized) {
        tetris = _tetris;
        map = new TetrisTile[tetris.size.x, tetris.size.y];
        for (int i = 0; i < tetris.size.x; i++) {
            for (int j = 0; j < tetris.size.y; j++) {
                if (tetris.map[i, j]) {
                    Vector2 localPosition = new Vector2(j, i) - tetris.center;
                    localPosition.y = -localPosition.y;
                    var obj = Instantiate(TetrisTilePrefab, transform, false);
                    obj.transform.localPosition = localPosition;
                    map[i, j] = obj.GetComponent<TetrisTile>();
                } else {
                    map[i, j] = null;
                }
            }
        }
        if (resized) {
            var scale = 1.0f / Mathf.Max(tetris.size.x, tetris.size.y);
            transform.localScale = new Vector3(scale, scale, 1);
        }
    }

    public bool CanPlaceTetris() {
        for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
                if (map[i, j] == null) continue;
                if (!map[i,j].CanPlace()) {
                    return false;
                }
            }
        }
        return true;
    }

    public bool CanFlipTetris() {
        for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
                if (map[i, j] == null) continue;
                if (map[i,j].CanFlip()) {
                    return true;
                }
            }
        }
        return false;
    }

    public bool PlaceTetris() {
        if (!CanPlaceTetris()) return false;
        for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
                if (map[i, j] == null) continue;
                map[i, j].Place();
            }
        }
        return true;
    }

    public bool PlaceFlip() {
        if (!CanFlipTetris()) return false;
        for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
                if (map[i, j] == null) continue;
                map[i, j].Flip();
            }
        }
        return true;
    }
}
