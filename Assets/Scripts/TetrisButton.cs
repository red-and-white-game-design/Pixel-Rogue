using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisButton : MonoBehaviour
{
    public int order;
    public Tetris tetris;

    public GameObject TetrisGO;
    public GameObject UITileGO;

    public Transform UI;

    int time;

    void Start()
    {
        if (Inventory.instance.tetris.Length <= order) {
            gameObject.SetActive(false);
        } else {
            var tetris = Inventory.instance.tetris[order];
            Init(tetris);
        }
    }

    void Update() {
        if (!(Inventory.instance.tetris.Length <= order)) {
            time = Inventory.instance.useTime[order];
            UI.gameObject.SetActive(time > 0);
        }
    }

    public void Init(Tetris tetris) {
        this.tetris = tetris;

        for (int i = 0; i < tetris.size.x; i++) {
            for (int j = 0; j < tetris.size.y; j++) {
                if (tetris.map[i, j]) {
                    Vector2 localPosition = new Vector2(j - tetris.center.x, tetris.center.y - i);
                    localPosition = 20f * localPosition;
                    var obj = Instantiate(UITileGO, UI, false);
                    obj.transform.localPosition = localPosition;
                }
            }
        }
    }

    public GameObject InstantiateNewBlock() {
        var obj = Instantiate(TetrisGO, new Vector3(), new Quaternion());
        obj.GetComponent<TetrisPrefab>().Init(tetris, true);
        return obj;
    }
}
