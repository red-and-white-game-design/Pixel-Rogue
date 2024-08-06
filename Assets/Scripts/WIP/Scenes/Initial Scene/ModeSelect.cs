using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public int currentMode = -1;
    public ModeButton CurrentButton = null;

    public List<ModeButton> ButtonList;

    public BlockSelect SelectionManager;

    void Start()
    {
        ButtonList[0].Select();
    }

    void Update()
    {
        
    }

    public void Cancel() {
        foreach (var btn in ButtonList) {
            btn.Cancel();
        }
    }

    public void UpdateSelectSetting(StartBlockType[] setting) {
        SelectionManager.UpdateSetting(setting);
    }
}
