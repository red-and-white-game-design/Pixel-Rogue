using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareLayer : UILayer
{
    public List<PackBlockViewButton> button;
    public BlockSelection blockSelection;

    public override void Emerge() {
        base.Emerge();
        foreach (var btn in button) {
            btn.Init();
        }
        blockSelection.Init();
        foreach (var btn in button) {
            btn.Init();
            btn.blockSelection = blockSelection;
        }
        for (int i = 0; i < button.Count; i++) {
            if (InventoryManager.instance.lastSelection.Contains(i)) {
                button[i].OnClick();
            }
        }
    }

    public override void Show() {
        base.Show();
        blockSelection.Init();
        foreach (var btn in button) {
            btn.Init();
            btn.blockSelection = blockSelection;
        }
        for (int i = 0; i < button.Count; i++) {
            if (InventoryManager.instance.lastSelection.Contains(i)) {
                button[i].OnClick();
            }
        }
    }
}
