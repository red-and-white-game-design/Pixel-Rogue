using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopPanel : MonoBehaviour
{
    public Text blockCountText;
    public Text formulationSizeText;
    public Text CoinCountText;
    public Text StarCountText;
    public Text ProgressText;

    void Start()
    {
        
    }

    void Update()
    {
        if (blockCountText.text != $"{InventoryManager.instance.brick.Count}") {
            blockCountText.text = $"{InventoryManager.instance.brick.Count}";
        }
        if (formulationSizeText.text != $"{InventoryManager.instance.formulationSize}") {
            formulationSizeText.text = $"{InventoryManager.instance.formulationSize}";
        }
        if (CoinCountText.text != $"{InventoryManager.instance.coinCount}") {
            CoinCountText.text = $"{InventoryManager.instance.coinCount}";
        }
        if (StarCountText.text != $"{InventoryManager.instance.starCount}") {
            StarCountText.text = $"{InventoryManager.instance.starCount}";
        }
        if (ProgressText.text != $"{ProgressManager.instance.currentStage} - {ProgressManager.instance.currentLevel + 1}") {
            ProgressText.text = $"{ProgressManager.instance.currentStage} - {ProgressManager.instance.currentLevel + 1}";
        }
    }
}
