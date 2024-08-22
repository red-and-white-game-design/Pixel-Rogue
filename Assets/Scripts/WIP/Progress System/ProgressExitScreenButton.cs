using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressExitScreenButton : MonoBehaviour
{
    public void OnClick() {
        var stage = ProgressManager.instance.currentStage;
        var level = ProgressManager.instance.level[stage - 1];
        var levelCount = level.Count;
        ProgressManager.instance.currentLevel = 0;
        ProgressManager.instance.totalLevel = levelCount;
    }
}
