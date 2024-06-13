using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public UILayer currentLayer = null;
    public List<UILayer> Layer;

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
        currentLayer.Show();
    }

    void Update() {

    }
}
