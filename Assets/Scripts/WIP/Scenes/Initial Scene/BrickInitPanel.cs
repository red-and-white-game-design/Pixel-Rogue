using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickInitPanel : MonoBehaviour
{
    public BlockSelect BlockSelectPanel;
    public UIManager UI;
    public UILayer ModeSelectingLayer;

    public int brickSize;

    public List<BrickInitButton> buttonList;

    public void Setup() {
        foreach (var button in buttonList) {
            button.Init(brickSize);
        }
    }
}
