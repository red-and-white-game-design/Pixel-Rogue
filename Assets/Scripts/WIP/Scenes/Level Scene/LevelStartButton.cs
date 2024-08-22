using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStartButton : MonoBehaviour
{
    public CanvasGroup startPanel;
    public LevelSystem levelSystem;
    
    public void OnClick() {
        Debug.Log("Click");
        startPanel.alpha = 0;
        startPanel.blocksRaycasts = false;
        levelSystem.StartGame();
    }
}
