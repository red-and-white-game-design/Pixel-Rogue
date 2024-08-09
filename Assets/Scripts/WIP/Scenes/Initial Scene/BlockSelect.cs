using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSelect : MonoBehaviour {
    public StartBlockType[] startSetting = new StartBlockType[4];
    public BlockButton[] blockButton;
    public UIManager UI;
    public UILayer BrickSelectLayer;
    public BrickInitPanel brickInitPanel;
    public int currentButtonID;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Cancel() {
        
    }

    public void UpdateSetting(StartBlockType[] setting) {
        for (int i = 0; i < 4; i++) {
            blockButton[i].SetBlockType(setting[i]);
            startSetting[i] = setting[i];
        }
    }
}
