using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockButton : MonoBehaviour
{
    public int id;
    public BlockSelect parent;
    public StartBlockType blockType;
    public int size;
    public int SelectedBrickID = 0;
    public Text SelectionText;
    private Button button;
    public BrickUIGenerate icon;

    public void SetBlockType(StartBlockType type) {
        blockType = type;
        SetButtonID(0);
        switch(type) {
            case StartBlockType.None:
                SelectionText.text = "-";
                size = 0;
                break;
            case StartBlockType.R1:
                SelectionText.text = "R1";
                size = 1;
                break;
            case StartBlockType.R2:
                SelectionText.text = "R2";
                size = 2;
                break;
            case StartBlockType.R3:
                SelectionText.text = "R3";
                size = 3;
                break;
            case StartBlockType.R4:
                SelectionText.text = "R4";
                size = 4;
                break;
            case StartBlockType.R5:
                SelectionText.text = "R5";
                size = 5;
                break;
            case StartBlockType.C1:
                SelectionText.text = "C1";
                size = 1;
                break;
            case StartBlockType.C2:
                SelectionText.text = "C2";
                size = 2;
                break;
            case StartBlockType.C3:
                SelectionText.text = "C3";
                size = 3;
                break;
            case StartBlockType.C4:
                SelectionText.text = "C4";
                size = 4;
                break;
            case StartBlockType.C5:
                SelectionText.text = "C5";
                size = 5;
                break;
        }
        switch(type) {
            case StartBlockType.C1:
            case StartBlockType.C2:
            case StartBlockType.C3:
            case StartBlockType.C4:
            case StartBlockType.C5:
                button.interactable = true;
                break;
            default:
                button.interactable = false;
                break;
        }
    }

    private void Start() {
        button = GetComponent<Button>();
    }

    public void OnClick() {
        parent.brickInitPanel.brickSize = size;
        parent.UI.SetCurrentLayer(parent.BrickSelectLayer);
        parent.brickInitPanel.Setup();
        parent.currentButtonID = id;
    }

    public void SetButtonID(int id) {
        SelectedBrickID = id;
        if (id == 0) {
            icon.Clear();
            var col = SelectionText.color;
            col.a = 1f;
            SelectionText.color = col;
        } else {
            icon.brickSize = size;
            icon.brickID = id;
            icon.Trigger();
            var col = SelectionText.color;
            col.a = 0f;
            SelectionText.color = col;
        }
    }
}
