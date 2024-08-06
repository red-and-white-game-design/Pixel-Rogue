using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StartBlockType {
    None,
    R1,
    R2,
    R3,
    R4,
    R5,
    C1,
    C2,
    C3,
    C4,
    C5,
}

public class ModeButton : MonoBehaviour
{
    public ModeSelect modeManager;
    private Button button;

    public int buttonMode = -1;
    public StartBlockType[] startSetting = new StartBlockType[4];

    private void Start() {
        button = GetComponent<Button>();
    }

    public void Select() {
        modeManager.Cancel();
        button.interactable = false;
        modeManager.currentMode = buttonMode;
        modeManager.UpdateSelectSetting(startSetting);
    }

    public void Cancel() {
        button.interactable = true;
    }

    public void OnClick() {
        Select();
    }
}
