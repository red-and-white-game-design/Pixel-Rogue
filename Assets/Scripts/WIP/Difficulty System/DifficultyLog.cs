using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLog : MonoBehaviour
{
    public Text log;
    private void Awake() {
        log.text = $"Difficulty: {(int)DifficultyManager.instance.difficulty}\nChallenge Mode: {DifficultyManager.instance.challengeMode}";
    }
}
