using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickUIGenerate : MonoBehaviour
{
    public Transform parent;
    public int brickSize;
    public int brickID;
    public GameObject Tile;
    public float scale = 0.8f;

    private List<GameObject> instance = new();

    public void Clear() {
        foreach (var GO in instance) {
            Destroy(GO);
        }
        instance.Clear();
    }

    public void Trigger() {
        Clear();
        var brick = BrickStorage.GetBrickFromIdentity(brickSize, brickID);
        GenerateBrickUI(parent, brick, Tile, scale);
    }

    public void GenerateBrickUI(Transform father, Brick brick, GameObject Tile, float scale) {
        var rect = father.GetComponent<RectTransform>();
        int width = Mathf.Max(brick.size.x, brick.size.y);
        scale = 0.3f + width * 0.1f;
        Vector2 UISize = new Vector2(rect.rect.width, rect.rect.height) * scale;
        Vector2 UpLeftCenter = UISize * (-(Vector2)brick.size / 2f / width);
        UpLeftCenter = new(UpLeftCenter.y, -UpLeftCenter.x);
        Vector2 TileSize = UISize / width;
        // Debug.Log($"TileSize: {TileSize}");
        var pattern = brick.GetPattern(false);
        for (int i = 0; i < brick.size.x; i++) {
            for (int j = 0; j < brick.size.y; j++) {
                if (pattern[i, j] == true) {
                    var position = UpLeftCenter + new Vector2(TileSize.x * j, -TileSize.y * i);
                    // Debug.Log($"UpLeftCenter: {UpLeftCenter}");
                    // Debug.Log($"dposition: {new Vector2(TileSize.x * j, -TileSize.y * i)}");
                    // Debug.Log($"position: {position}");
                    var obj = Instantiate(Tile, father);
                    var tileRect = obj.GetComponent<RectTransform>();
                    tileRect.localPosition = position;
                    tileRect.sizeDelta = UISize / width;
                    // Debug.Log($"UIsize: {UISize}, width: {width}");
                    instance.Add(obj);
                }
            }
        }
    }
}
