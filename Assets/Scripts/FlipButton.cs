using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipButton : MonoBehaviour {
    public Tetris tetris = new(new int[3,3]{
        {1, 1, 1},
        {1, 1, 1},
        {1, 1, 1},
    });
    int time;
    public Text timeText;
    private void Update() {
        time = Inventory.instance.flipTime;
        timeText.text = time.ToString();
    }
}
