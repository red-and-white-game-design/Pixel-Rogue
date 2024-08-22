using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackBlockViewButton : MonoBehaviour {
    public int id;

    private BrickUIGenerate brickUIGenerate;
    private Button button;
    private bool selected;

    public Image SelectedUI;
    public BlockSelection blockSelection;

    void Start() {
        brickUIGenerate = GetComponent<BrickUIGenerate>();
        button = GetComponent<Button>();
    }

    public void Init() {
        if (id < InventoryManager.instance.brick.Count) {
            brickUIGenerate.Clear();
            brickUIGenerate.brickSize = InventoryManager.instance.brick[id].size;
            brickUIGenerate.brickID = InventoryManager.instance.brick[id].id;
            brickUIGenerate.Trigger();
            button.interactable = true;
        } else {
            brickUIGenerate.Clear();
            button.interactable = false;
        }
    }

    public void OnClick() {
        if (!selected && blockSelection.CanSelect()) {
            selected = true;
            Color32 col = SelectedUI.color;
            col.a = 255;
            SelectedUI.color = col;
            blockSelection.Modify(1);
            if (!blockSelection.selection.Contains(id)) {
                blockSelection.selection.Add(id);
            }
        } else if (selected) {
            selected = false;
            Color32 col = SelectedUI.color;
            col.a = 0;
            SelectedUI.color = col;
            blockSelection.Modify(-1);
            if (blockSelection.selection.Contains(id)) {
                blockSelection.selection.Remove(id);
            }
        }
    }
}
