using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareConfirmButton : MonoBehaviour
{
    public BlockSelection blockSelection;

    public void OnClick() {
        var list = FormulationManager.instance.formulation;
        var selectedPosition = blockSelection.selection;
        var inventory = InventoryManager.instance.brick;
        InventoryManager.instance.lastSelection = new();
        for (int i = 0; i < inventory.Count; i++) {
            if (selectedPosition.Contains(i)) {
                list.Add(inventory[i]);
                InventoryManager.instance.lastSelection.Add(i);
            }
        }
    }
}
