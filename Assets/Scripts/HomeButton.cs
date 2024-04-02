using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour
{
    public void OnClick() {
        GameManager.instance.LoadSceneByName("Title Scene");
    }
}
