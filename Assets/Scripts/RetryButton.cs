using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour {
    public void OnClick() {
        GameManager.instance.LoadSceneByName("Level");
    }
}
