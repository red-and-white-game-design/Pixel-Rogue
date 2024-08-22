using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialConfirmButton : MonoBehaviour
{
    public List<BlockButton> blockButton;

    public void OnClick() {
        foreach (var btn in blockButton) {
            switch (btn.blockType) {
                case StartBlockType.R1:
                case StartBlockType.R2:
                case StartBlockType.R3:
                case StartBlockType.R4:
                case StartBlockType.R5:
                    var id = Random.Range(0, BrickStorage.GetBrickListFromSize(btn.size).Count) + 1;
                    InventoryManager.instance.AddBrick(new BrickID(btn.size, id));
                    // Debug.Log($"size{btn.size} id{id}");
                    break;
                case StartBlockType.C1:
                case StartBlockType.C2:
                case StartBlockType.C3:
                case StartBlockType.C4:
                case StartBlockType.C5:
                    InventoryManager.instance.AddBrick(new BrickID(btn.size, btn.SelectedBrickID));
                    // Debug.Log($"size{btn.size} id{btn.SelectedBrickID}");
                    break;
                default:
                    break;
            }
        }
        ProgressManager.instance.Init();
        ProgressManager.instance.currentStage = 1;
    }
}
