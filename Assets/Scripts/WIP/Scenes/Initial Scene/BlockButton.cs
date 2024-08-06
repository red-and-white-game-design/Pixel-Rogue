using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockButton : MonoBehaviour
{
    public StartBlockType blockType;
    public Brick SelectedBrick = null;
    public Text SelectionText;
    private Button button;

    public void SetBlockType(StartBlockType type) {
        SelectedBrick = null;
        switch(type) {
            case StartBlockType.None:
                SelectionText.text = "-";
                break;
            case StartBlockType.R1:
                SelectionText.text = "R1";
                break;
            case StartBlockType.R2:
                SelectionText.text = "R2";
                break;
            case StartBlockType.R3:
                SelectionText.text = "R3";
                break;
            case StartBlockType.R4:
                SelectionText.text = "R4";
                break;
            case StartBlockType.R5:
                SelectionText.text = "R5";
                break;
            case StartBlockType.C1:
                SelectionText.text = "C1";
                break;
            case StartBlockType.C2:
                SelectionText.text = "C2";
                break;
            case StartBlockType.C3:
                SelectionText.text = "C3";
                break;
            case StartBlockType.C4:
                SelectionText.text = "C4";
                break;
            case StartBlockType.C5:
                SelectionText.text = "C5";
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
}
