using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeButton : MonoBehaviour
{
    public DifficultyUI difficultyUI;

    public GameObject button;
    public Image buttonBackground;
    public Text buttonText;
    public float[] buttonPosition;

    public void OnClick() {
        difficultyUI.challengeMode ^= true;
        SetChallengeMode(difficultyUI.challengeMode);
    }

    public void SetChallengeMode(bool mode) {
        if (mode) {
            LeanTween.moveLocalX(button, buttonPosition[1], 0.15f).setEase(LeanTweenType.easeOutQuad);
            buttonText.text = "ON";
            buttonBackground.color = Color.red;
            buttonText.color = Color.white;
        } else {
            LeanTween.moveLocalX(button, buttonPosition[0], 0.15f).setEase(LeanTweenType.easeOutQuad);
            buttonText.text = "OFF";
            buttonBackground.color = Color.white;
            buttonText.color = Color.black;
        }
    }
}
