using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILayer : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    private void Start() {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Fade() {
        canvasGroup.blocksRaycasts = true;
        LeanTween.alphaCanvas(canvasGroup, 0f, 0.5f).setEase(LeanTweenType.easeOutQuad);
    }

    public void Emerge() {
        canvasGroup.blocksRaycasts = true;
        LeanTween.alphaCanvas(canvasGroup, 1f, 0.5f).setEase(LeanTweenType.easeInQuad);
    }

    public void Show() {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void Hide() {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0f;
    }
}
