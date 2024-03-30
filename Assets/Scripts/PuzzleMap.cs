using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMap : MonoBehaviour
{
    public static PuzzleMap instance;
    public GameObject TileGO;

    public Vector2Int size;
    public string[] map;
    public string[] star;
    public string[] target;

    private PuzzleTile[,] tile;

    void Start() {
        if (instance == null) {
            instance = this;
        }
        size = new(9, 9);
        map = new string[9] {
            "111111111",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "111111111",
        };
        star = new string[9] {
            "000000000",
            "000111000",
            "000000000",
            "010000010",
            "010000010",
            "001000100",
            "011000110",
            "001000100",
            "000000000",
        };
        target = new string[9] {
            "000000000",
            "010000010",
            "001010100",
            "000101000",
            "000101000",
            "000101000",
            "000010000",
            "000010000",
            "000000000",
        };
        Init();
    }

    void Update()
    {
        
    }

    private void Init() {
        tile = new PuzzleTile[size.x, size.y];
        var center = new Vector2(size.y - 1, size.x - 1) * 0.5f;
        for (int i = 0; i < size.x; i++) {
            for (int j = 0; j < size.y; j++) {
                // (i, j) -> (j, -i)
                var v = new Vector2(i, j) - center;
                Vector2 localPosition = new(v.y, -v.x);

                var obj = Instantiate(TileGO, transform, false);
                obj.transform.localPosition = localPosition;
                tile[i, j] = obj.GetComponent<PuzzleTile>();
                tile[i, j].type = (BlockType)Char.ToInt(map[i][j]);
                tile[i, j].hasStar = Char.ToBool(star[i][j]);
                tile[i, j].hasTarget = Char.ToBool(target[i][j]);
            }
        }
    }

    public void Check() {
        bool accomplishment = true;
        foreach (var t in tile) {
            if (!t.Check()) {
                accomplishment &= false;
            }
        }
        
    }
}
