using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public DifficultyUI DifficultyUI;
    public int delta;

    private Button button;

    private void Start() {
        button = GetComponent<Button>();
        CheckAvailible();
    }

    public void CheckAvailible() {
        button.interactable = DifficultyUI.CanAddDifficulty(delta);
    }
}
