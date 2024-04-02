using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float EndingTime;
    public Image TimeBar;

    private float currentTime = 0f;

    public void Set(float time) {
        EndingTime = time;
    }

    public void Init() {
        currentTime = 0f;
    }

    void Start()
    {
        Init();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > EndingTime) {
            currentTime = EndingTime;
            GameManager.instance.GameEnd();
        }
        UpdateUI();
    }

    void UpdateUI() {
        TimeBar.fillAmount = 1f - currentTime / EndingTime;
        if (TimeBar.fillAmount >= 0.5f) {
            TimeBar.color = new Color32(59, 243, 94, 255);
        } else if (TimeBar.fillAmount >= 0.2f) {
            TimeBar.color = new Color32(243, 220, 59, 255);
        } else {
            TimeBar.color = new Color32(244, 0, 2, 255);
        }
    }
}
