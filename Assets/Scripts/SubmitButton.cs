using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitButton : MonoBehaviour
{
    public void OnClick() {
        GameManager.instance.GameEnd();
    }
}
