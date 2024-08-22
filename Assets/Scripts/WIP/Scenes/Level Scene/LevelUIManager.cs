using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUIManager : MonoBehaviour {

    public UILayer currentLayer = null;
    public List<UILayer> Layer;

    public UILayer PrepareLayer;
    public UILayer EventLayer;
    public UILayer ShopLayer;

    public void SetCurrentLayer(UILayer layer) {
        if (currentLayer != null) {
            currentLayer.Fade();
        }
        if (layer != null) {
            layer.Emerge();
        }
        currentLayer = layer;
    }

    void Start() {
        foreach (var layer in Layer) {
            layer.Hide();
        }

        var stage = ProgressManager.instance.currentStage;
        var level = ProgressManager.instance.level[stage - 1];
        var currentLevel = ProgressManager.instance.currentLevel;
        switch (level[currentLevel]) {
            case LevelType.Level:
            case LevelType.BossLevel:
                currentLayer = PrepareLayer;
                break;
            case LevelType.Event:
                currentLayer = EventLayer;
                break;
            case LevelType.Shop:
                currentLayer = ShopLayer;
                break;
        }
        currentLayer.Show();
    }
}
