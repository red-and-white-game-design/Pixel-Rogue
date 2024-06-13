using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyUI : MonoBehaviour
{
    public Text DifficultyText;

    public int difficulty = 0;
    int maxDifficulty = 6;

    public List<GameObject> Description;
    public GameObject DescriptionContainer;
    private Vector3 lastCenterPosition;

    public void AddDifficulty(int value) {
        if (!CanAddDifficulty(value)) return;
        if (value > 0) {
            for (int i = 0; i < Description.Count; i++) {
                var description = Description[i] != null ? Description[i].GetComponent<CanvasGroup>() : null;
                if (description != null && difficulty < i && i <= difficulty + value) {
                    LeanTween.alphaCanvas(description, 1f, 0.5f);
                }
            }
        } else {
            for (int i = 0; i < Description.Count; i++) {
                var description = Description[i] != null ? Description[i].GetComponent<CanvasGroup>() : null;
                if (description != null && difficulty + value < i && i <= difficulty) {
                    LeanTween.alphaCanvas(description, 0f, 0.1f);
                }
            }

        }
        difficulty += value;
        UpdateDifficulty(difficulty);
    }

    public bool CanAddDifficulty(int value) {
        int newDifficulty = difficulty + value;
        return newDifficulty >= 0 && newDifficulty <= maxDifficulty;
    }

    private void UpdateDifficulty(int value) {
        DifficultyText.text = value.ToString();
        Vector3 center = new();
        if (Description.Count >= 1) {
            var description1 = Description[0] != null ? Description[0] : null;
            var description2 = Description[difficulty] != null ? Description[difficulty] : null;
            center = (description1.transform.position + description2.transform.position) / 2f;
        }
        LeanTween.moveY(DescriptionContainer, DescriptionContainer.transform.position.y + lastCenterPosition.y - center.y, 0.2f);
    }

    private void Start() {
        var description = Description[0] != null ? Description[0] : null;
        lastCenterPosition = description.transform.position;
        UpdateDifficulty(difficulty);
    }
}
