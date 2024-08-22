using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressLevelBar : MonoBehaviour
{
    public GameObject ProgressLevelIconGO;
    public List<ProgressLevelIcon> icon;
    public int stage;

    public Text StageCountText;

    private RectTransform rect;

    private void Start() {
        rect = GetComponent<RectTransform>();
        var stage = ProgressManager.instance.currentStage;
        var level = ProgressManager.instance.level[stage - 1];
        var levelCount = level.Count;

        StageCountText.text = stage.ToString();

        rect.sizeDelta = new Vector2(levelCount * 300f + 20f, rect.rect.size.y);

        icon = new();
        for (int i = 0; i < levelCount; i++) {
            var obj = Instantiate(ProgressLevelIconGO, transform);
            icon.Add(obj.GetComponent<ProgressLevelIcon>());
            var iconRect = obj.GetComponent<RectTransform>();
            iconRect.anchoredPosition = new((i - (levelCount - 1) / 2f) * 300f, 0);
            icon[i].Init(level[i]);
        }
    }
}
