using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSelection : MonoBehaviour
{
    public int size;
    public int currentSize;
    public List<int> selection = new();

    public void Init() {
        size = InventoryManager.instance.formulationSize;
        currentSize = 0;
        selection = new();
    }

    public bool CanSelect() {
        return currentSize < size;
    }

    public void Modify(int val) {
        currentSize += val;
    }
}
