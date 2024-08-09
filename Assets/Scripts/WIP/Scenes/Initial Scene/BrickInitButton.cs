using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickInitButton : MonoBehaviour
{
    public BrickInitPanel parent;
    public int id;
    private Button button;

    private void Start() {
        button = GetComponent<Button>();
    }

    public void Init(int brickSize) {
        var brickUIGenerate = GetComponent<BrickUIGenerate>();
        brickUIGenerate.brickSize = brickSize;
        brickUIGenerate.brickID = id;
        // Debug.Log($"id: {id}, GetBrickListFromSize{brickSize} : {BrickStorage.GetBrickListFromSize(brickSize).Count}");
        if (id <= BrickStorage.GetBrickListFromSize(brickSize).Count) {
            button.interactable = true;
            brickUIGenerate.Trigger();
        } else {
            button.interactable = false;
            brickUIGenerate.Clear();
        }
    }

    public void OnClick() {
        // Debug.Log($"{parent}");
        // Debug.Log($"{parent.BlockSelectPanel}");
        // Debug.Log($"{parent.BlockSelectPanel.blockButton}");
        // Debug.Log($"{parent.BlockSelectPanel.blockButton[parent.BlockSelectPanel.currentButtonID]}");
        parent.BlockSelectPanel.blockButton[parent.BlockSelectPanel.currentButtonID].SetButtonID(id);
        parent.UI.SetCurrentLayer(parent.ModeSelectingLayer);
    }
}
