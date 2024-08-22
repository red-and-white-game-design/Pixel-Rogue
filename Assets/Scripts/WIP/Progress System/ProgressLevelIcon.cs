using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressLevelIcon : MonoBehaviour
{
    public Image backGround;
    public Text text;

    public void Init(LevelType type) {
        switch (type) {
            case LevelType.Level:
                backGround.color = new Color32(255, 231, 144, 255);
                text.text = "关卡";
                text.color = new Color32(50, 50, 50, 255);
                break;
            case LevelType.BossLevel:
                backGround.color = new Color32(255, 38, 0, 255);
                text.text = "BOSS";
                text.color = Color.white;
                break;
            case LevelType.Event:
                backGround.color = new Color32(141, 251, 255, 255);
                text.text = "事件";
                text.color = new Color32(50, 50, 50, 255);
                break;
            case LevelType.Shop:
                backGround.color = new Color32(143, 255, 183, 255);
                text.text = "商店";
                text.color = new Color32(50, 50, 50, 255);
                break;
        }
    }
}
