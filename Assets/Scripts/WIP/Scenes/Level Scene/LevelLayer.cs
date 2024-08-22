using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLayer : UILayer {
    public List<LevelBlockButton> button;

    public override void Emerge() {
        base.Emerge();
        foreach (var btn in button) {
            btn.Init();
        }
    }

    public override void Show() {
        base.Show();
        foreach (var btn in button) {
            btn.Init();
        }
    }
}
