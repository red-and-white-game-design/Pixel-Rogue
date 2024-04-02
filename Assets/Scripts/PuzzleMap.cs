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
        Inventory.instance.Init();
        if (instance == null) {
            instance = this;
        }
        int id = Random.Range(0, 3);
        size = MapPool.size[id];
        map = MapPool.map[id];
        star = MapPool.star[id];
        target = MapPool.target[id];
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
            accomplishment = accomplishment && t.Check();
        }
        Debug.Log(accomplishment);
        int score = 0;
        for (int i = 0; i < size.x; i++) {
            for (int j = 0; j < size.y; j++) {
                score += tile[i, j].GetScore();
            }
       }
        GameManager.instance.GameResult(accomplishment, score);
    }
}
